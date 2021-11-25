using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.DevOps.Notificator;
using Azure.DevOps.Notificator.Extensions;
using Azure.DevOps.Notificator.Handlers;
using BotFramework.Extensions;
using EventHandler = Azure.DevOps.Notificator.Handlers.EventHandler;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers()
		.AddJsonOptions(options =>
		{
			options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
			options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
		});

services.AddEndpointsApiExplorer()
        .AddSwaggerGen();

var _botConfiguration = builder.Configuration
							   .GetSection("Bot")
							   .Get<BotConfiguration>();

services.AddNotifier
(
	_botConfiguration.Token,
	_botConfiguration.ChatId,
	branchBuilder => branchBuilder.UseHandler<ExceptionHandler>()
								  .UseHandler<EventHandler>()
);

var application = builder.Build();
var environment = application.Environment;

if (environment.IsDevelopment())
{
    application.UseSwagger()
               .UseSwaggerUI();
}

application.UseHttpsRedirection()
		   .UseRouting();

application.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

application.Run();