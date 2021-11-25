using Azure.DevOps.Notificator.Types;
using Microsoft.AspNetCore.Mvc;
using RequestDelegate = BotFramework.RequestDelegate;

namespace Azure.DevOps.Notificator.Controllers;

[ApiController]
[Route("[controller]")]
public class BotController : ControllerBase
{
    private readonly ILogger<BotController> _logger;
 
    /// <summary>
    /// Сконфигурированная ветвь обработчиков
    /// </summary>
    private readonly RequestDelegate _branch;

    /// <summary>
    /// Базовый конструктор
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="branchBuilder"></param>
    public BotController(ILogger<BotController> logger, RequestDelegate branch)
    {
        _logger = logger;
        _branch = branch;
    }

    /// <summary>
    /// Принимает Azure DevOps событие по вебхуку
    /// </summary>
    /// <param name="devOpsEvent">Объект события</param>
    [HttpPost(template:"GetUpdates")]
    public async Task<IActionResult> Post([FromBody] Event devOpsEvent)
    {
        if (_logger.IsEnabled(LogLevel.Information))
        {
            _logger.LogInformation("Событие с типом \"{EventType}\" получено и отправлено в цепочку обработчиков", devOpsEvent.EventType);    
        }

        await _branch(devOpsEvent);

        return Ok();
    }
}