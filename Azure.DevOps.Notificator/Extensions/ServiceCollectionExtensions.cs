using Azure.DevOps.Notificator.Handlers;
using BotFramework.Extensions;
using BotFramework.Interfaces;
using Microsoft.Extensions.DependencyInjection.Extensions;
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
    public static IServiceCollection AddNotifier(this IServiceCollection services, string token, string chatId, Action<IBranchBuilder> configureBranch)
    {
        services.TryAddScoped<ITelegramBotClient>
        (
            _ => new TelegramBotClient(token)
        );
        
        services.TryAddScoped
        (
            _ => new ChatId(chatId)
        );
        
        services.AddBotFramework()
                .AddHandler<ExceptionHandler>()
                .AddHandler<EventHandler>();

        services.TryAddScoped<RequestDelegate>
        (
            serviceProvider =>
            {
                var branchBuilder = serviceProvider.GetRequiredService<IBranchBuilder>();

                configureBranch(branchBuilder);

                return branchBuilder.Build();
            }
        );

        return services;
    }
}