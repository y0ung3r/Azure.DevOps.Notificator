using BotFramework.Extensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers()
		.AddNewtonsoftJson(options =>
		{
			var serializerSettings = options.SerializerSettings;
			serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
			serializerSettings.Formatting = Formatting.None;
			serializerSettings.NullValueHandling = NullValueHandling.Ignore;
		});

services.AddEndpointsApiExplorer()
        .AddSwaggerGen();

services.AddBotFramework();

var application = builder.Build();
var environment = application.Environment;

if (environment.IsDevelopment())
{
    application.UseSwagger()
               .UseSwaggerUI();
}

application.UseHttpsRedirection();

application.MapControllers();

application.Run();