using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public partial class Reviewer
{
    
}

public class Author
{
    [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; }
    
    [JsonProperty("reviewerUrl")]
    public object ReviewerUrl { get; set; }

    [JsonProperty("vote", NullValueHandling = NullValueHandling.Ignore)]
    public long? Vote { get; set; }

    [JsonProperty("isContainer", NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsContainer { get; set; }
    
    [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
    public string Name { get; set; }

    [JsonProperty("displayName", NullValueHandling = NullValueHandling.Ignore)]
    public string DisplayName { get; set; }

    [JsonProperty("uniqueName", NullValueHandling = NullValueHandling.Ignore)]
    public string UniqueName { get; set; }

    [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
    public string Email { get; set; }

    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Url { get; set; }

    [JsonProperty("imageUrl", NullValueHandling = NullValueHandling.Ignore)]
    public Uri ImageUrl { get; set; }
}