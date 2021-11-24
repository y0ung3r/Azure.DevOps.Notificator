using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class CheckedInResource
{
    [JsonProperty("changesetId", NullValueHandling = NullValueHandling.Ignore)]
    public long? ChangesetId { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Url { get; set; }

    [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
    public Author Author { get; set; }

    [JsonProperty("checkedInBy", NullValueHandling = NullValueHandling.Ignore)]
    public Author CheckedInBy { get; set; }

    [JsonProperty("createdDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; }

    [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
    public string Comment { get; set; }
}