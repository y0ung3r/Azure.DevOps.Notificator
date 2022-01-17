using BotFramework.Handlers.Common;
using Microsoft.VisualStudio.Services.ServiceHooks.WebApi;
using RequestDelegate = BotFramework.RequestDelegate;

namespace Azure.DevOps.Notificator.Handlers;

/// <summary>
/// Обработчик исключений
/// </summary>
public class ExceptionHandler : RequestHandlerBase<Event>
{
	private readonly ILogger<ExceptionHandler> _logger;

	/// <summary>
	/// Базовый конструктор
	/// </summary>
	/// <param name="logger">Сервис логгирования</param>
	public ExceptionHandler(ILogger<ExceptionHandler> logger)
	{
		_logger = logger;
	}

	/// <summary>Передает запрос следующему обработчику по цепочке и логгирует исключения в случае их появления</summary>
	/// <param name="request">Запрос</param>
	/// <param name="nextHandler">Следующий обработчик по цепочке</param>
	public override async Task HandleAsync(Event request, RequestDelegate nextHandler)
	{
		try
		{
			await nextHandler(request);
		}

		catch (Exception error)
		{
			_logger?.LogError(error, "Невозможно обработать запрос: {ExceptionMessage}", error.Message);
		}
	}
}