using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Account
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; }
}