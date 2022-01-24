using Azure.DevOps.Notificator.Extensions;
using Azure.DevOps.Notificator.Handlers;
using BotFramework.Extensions;
using Microsoft.AspNetCore.Mvc;
using EventHandler = Azure.DevOps.Notificator.Handlers.EventHandler;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();

services.Configure<ApiBehaviorOptions>(options =>
{
	options.SuppressModelStateInvalidFilter = true;
});

services.AddEndpointsApiExplorer()
	.AddSwaggerGen();

services.AddNotifier(builder.Configuration,
	branchBuilder => branchBuilder.UseHandler<ExceptionHandler>()
		.UseHandler<EventHandler>());

var application = builder.Build();
var environment = application.Environment;

if (environment.IsDevelopment())
{
	application.UseDeveloperExceptionPage()
		.UseSwagger()
		.UseSwaggerUI();
}

application.UseHttpsRedirection()
	.UseRouting()
	.UseCors();

application.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

application.Run();