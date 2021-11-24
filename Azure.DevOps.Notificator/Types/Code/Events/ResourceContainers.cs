using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class ResourceContainers
{
    [JsonProperty("collection", NullValueHandling = NullValueHandling.Ignore)]
    public Account Collection { get; set; }

    [JsonProperty("account", NullValueHandling = NullValueHandling.Ignore)]
    public Account Account { get; set; }

    [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
    public Account Project { get; set; }
}