namespace Azure.DevOps.Notificator;

/// <summary>
/// Параметры бота
/// </summary>
public class BotConfiguration
{
	/// <summary>
	/// Telegram API Token
	/// </summary>
	public string Token { get; init; }

	/// <summary>
	/// Идентификатор чата, в который будет происходить отправка сообщений
	/// </summary>
	public string ChatId { get; init; }
}