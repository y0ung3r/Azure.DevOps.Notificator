using BotFramework.Handlers.Common;
using Microsoft.VisualStudio.Services.ServiceHooks.WebApi;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using RequestDelegate = BotFramework.RequestDelegate;

namespace Azure.DevOps.Notificator.Handlers;

/// <summary>
/// Обработчик Azure DevOps события
/// </summary>
public class EventHandler : RequestHandlerBase<Event>
{
	private readonly ILogger<EventHandler> _logger;

	private readonly ChatId _chatId;

	private readonly ITelegramBotClient _client;

	/// <summary>
	/// Базовый конструктор
	/// </summary>
	/// <param name="logger">Сервис логгирования</param>
	/// <param name="chat">Чат, в который нужно отправить сообщение</param>
	/// <param name="client">Клиент Telegram</param>
	public EventHandler(ILogger<EventHandler> logger, ChatId chatId, ITelegramBotClient client)
	{
		_logger = logger;
		_chatId = chatId;
		_client = client;
	}

	/// <summary>Отправляет сообщение о событии в бот Telegram'а</summary>
	/// <param name="request">Запрос</param>
	/// <param name="nextHandler">Следующий обработчик по цепочке</param>
	public override Task HandleAsync(Event request, RequestDelegate nextHandler)
	{
		if (_logger.IsEnabled(LogLevel.Information))
		{
			_logger.LogInformation("Отправка информации о событии \"{EventType}\" Telegram боту в чат с идентификатором {ChatId}",
				request.EventType,
				_chatId);
		}

		return _client.SendTextMessageAsync(_chatId,
			request.DetailedMessage.Text,
			ParseMode.Markdown);
	}
}