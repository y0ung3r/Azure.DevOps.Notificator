using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Commit
{
    [JsonProperty("commitId", NullValueHandling = NullValueHandling.Ignore)]
    public string CommitId { get; set; }

    [JsonProperty("author", NullValueHandling = NullValueHandling.Ignore)]
    public Author Author { get; set; }

    [JsonProperty("committer", NullValueHandling = NullValueHandling.Ignore)]
    public Author Committer { get; set; }

    [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
    public string Comment { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Url { get; set; }
}