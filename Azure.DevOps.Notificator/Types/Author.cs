namespace Azure.DevOps.Notificator.Types;

public class Author
{
	public Guid? Id { get; set; }

	public object ReviewerUrl { get; set; }

	public long? Vote { get; set; }

	public bool? IsContainer { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public string UniqueName { get; set; }

	public string Email { get; set; }

	public DateTimeOffset? Date { get; set; }

	public Uri Url { get; set; }

	public Uri ImageUrl { get; set; }
}