using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Project
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Url { get; set; }

    [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
    public string State { get; set; }
}