using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Resource
{
    [JsonProperty("pullRequestId", NullValueHandling = NullValueHandling.Ignore)]
    public long? PullRequestId { get; set; }

    [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
    public string Status { get; set; }

    [JsonProperty("createdBy", NullValueHandling = NullValueHandling.Ignore)]
    public Author CreatedBy { get; set; }

    [JsonProperty("creationDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreationDate { get; set; }

    [JsonProperty("closedDate", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ClosedDate { get; set; }

    [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
    public string Title { get; set; }

    [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
    public string Description { get; set; }

    [JsonProperty("sourceRefName", NullValueHandling = NullValueHandling.Ignore)]
    public string SourceRefName { get; set; }

    [JsonProperty("targetRefName", NullValueHandling = NullValueHandling.Ignore)]
    public string TargetRefName { get; set; }

    [JsonProperty("mergeStatus", NullValueHandling = NullValueHandling.Ignore)]
    public string MergeStatus { get; set; }

    [JsonProperty("mergeId", NullValueHandling = NullValueHandling.Ignore)]
    public Guid? MergeId { get; set; }

    [JsonProperty("lastMergeSourceCommit", NullValueHandling = NullValueHandling.Ignore)]
    public LastMergeCommit LastMergeSourceCommit { get; set; }

    [JsonProperty("lastMergeTargetCommit", NullValueHandling = NullValueHandling.Ignore)]
    public LastMergeCommit LastMergeTargetCommit { get; set; }

    [JsonProperty("lastMergeCommit", NullValueHandling = NullValueHandling.Ignore)]
    public LastMergeCommit LastMergeCommit { get; set; }

    [JsonProperty("reviewers", NullValueHandling = NullValueHandling.Ignore)]
    public List<Reviewer> Reviewers { get; set; }

    [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
    public Uri Url { get; set; }
    
    [JsonProperty("commits", NullValueHandling = NullValueHandling.Ignore)]
    public List<Commit> Commits { get; set; }

    [JsonProperty("refUpdates", NullValueHandling = NullValueHandling.Ignore)]
    public List<RefUpdate> RefUpdates { get; set; }

    [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
    public Repository Repository { get; set; }

    [JsonProperty("pushedBy", NullValueHandling = NullValueHandling.Ignore)]
    public Author PushedBy { get; set; }

    [JsonProperty("pushId", NullValueHandling = NullValueHandling.Ignore)]
    public long? PushId { get; set; }

    [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; }
}