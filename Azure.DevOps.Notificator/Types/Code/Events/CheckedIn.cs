using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class CheckedIn
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; }

    [JsonProperty("eventType", NullValueHandling = NullValueHandling.Ignore)]
    public string EventType { get; set; }

    [JsonProperty("publisherId", NullValueHandling = NullValueHandling.Ignore)]
    public string PublisherId { get; set; }

    [JsonProperty("scope", NullValueHandling = NullValueHandling.Ignore)]
    public string Scope { get; set; }

    [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
    public Message Message { get; set; }

    [JsonProperty("detailedMessage", NullValueHandling = NullValueHandling.Ignore)]
    public Message DetailedMessage { get; set; }

    [JsonProperty("resource", NullValueHandling = NullValueHandling.Ignore)]
    public CheckedInResource Resource { get; set; }

    [JsonProperty("resourceVersion", NullValueHandling = NullValueHandling.Ignore)]
    public string ResourceVersion { get; set; }

    [JsonProperty("resourceContainers", NullValueHandling = NullValueHandling.Ignore)]
    public ResourceContainers ResourceContainers { get; set; }

    [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; }
}