using BotFramework.Extensions;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;

services.AddControllers();

services.AddEndpointsApiExplorer()
        .AddSwaggerGen();

services.AddBotFramework();

var application = builder.Build();

if (application.Environment.IsDevelopment())
{
    application.UseSwagger()
               .UseSwaggerUI();
}

application.UseHttpsRedirection();

application.MapControllers();

application.Run();