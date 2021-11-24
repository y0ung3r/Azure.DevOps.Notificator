namespace Azure.DevOps.Notificator.Types;

public class Resource
{
	public long? PullRequestId { get; set; }

	public string Status { get; set; }

	public Author CreatedBy { get; set; }

	public DateTimeOffset? CreationDate { get; set; }

	public DateTimeOffset? ClosedDate { get; set; }

	public string Title { get; set; }

	public string Description { get; set; }

	public string SourceRefName { get; set; }

	public string TargetRefName { get; set; }

	public string MergeStatus { get; set; }

	public Guid? MergeId { get; set; }

	public LastMergeCommit LastMergeSourceCommit { get; set; }

	public LastMergeCommit LastMergeTargetCommit { get; set; }

	public LastMergeCommit LastMergeCommit { get; set; }

	public List<Author> Reviewers { get; set; }

	public long? ChangesetId { get; set; }
	
	public Uri Url { get; set; }

	public List<Commit> Commits { get; set; }

	public List<RefUpdate> RefUpdates { get; set; }

	public Repository Repository { get; set; }

	public Author PushedBy { get; set; }

	public long? PushId { get; set; }
	
	public DateTimeOffset? Date { get; set; }
}