namespace Azure.DevOps.Notificator.Types;

public class Commit
{
	public string CommitId { get; set; }

	public Author Author { get; set; }

	public Author Committer { get; set; }

	public string Comment { get; set; }

	public Uri Url { get; set; }
}