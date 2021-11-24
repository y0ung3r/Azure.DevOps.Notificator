using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Repository
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; }

    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Url { get; set; }

    [JsonProperty("project", NullValueHandling = NullValueHandling.Ignore)]
    public Project Project { get; set; }

    [JsonProperty("defaultBranch", NullValueHandling = NullValueHandling.Ignore)]
    public string DefaultBranch { get; set; }

    [JsonProperty("remoteUrl", NullValueHandling = NullValueHandling.Ignore)]
    public Uri RemoteUrl { get; set; }
}