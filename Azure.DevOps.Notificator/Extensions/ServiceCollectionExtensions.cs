using Azure.DevOps.Notificator.Handlers;
using BotFramework.Extensions;
using BotFramework.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Types;
using EventHandler = Azure.DevOps.Notificator.Handlers.EventHandler;
using RequestDelegate = BotFramework.RequestDelegate;

namespace Azure.DevOps.Notificator.Extensions;

/// <summary>
/// Методы-расширения для <see cref=""/>
/// </summary>
public static class ServiceCollectionExtensions
{
	/// <summary>
	/// Конфигурирует текущее приложение
	/// </summary>
	/// <param name="services">Сервисы</param>
	/// <param name="token">Токен от Telegram Bot API</param>
	/// <param name="configureBranch">Конфигуратор для цепочки обработчиков</param>
	public static IServiceCollection AddNotifier(this IServiceCollection services,
												IConfiguration configuration,
												Action<IBranchBuilder> configureBranch)
	{
		services.Configure<BotOptions>(configuration.GetSection("Bot"));

		services.TryAddScoped<ITelegramBotClient>(serviceProvider =>
		{
			var options = serviceProvider.GetService<IOptions<BotOptions>>();

			return new TelegramBotClient(options.Value.Token);
		});

		services.TryAddScoped(serviceProvider =>
		{
			var options = serviceProvider.GetService<IOptions<BotOptions>>();

			return new ChatId(options.Value.ChatId);
		});

		services.AddBotFramework()
			.AddHandler<ExceptionHandler>()
			.AddHandler<EventHandler>();

		services.TryAddScoped<RequestDelegate>(serviceProvider =>
		{
			var branchBuilder = serviceProvider.GetRequiredService<IBranchBuilder>();

			configureBranch(branchBuilder);

			return branchBuilder.Build();
		});

		return services;
	}
}