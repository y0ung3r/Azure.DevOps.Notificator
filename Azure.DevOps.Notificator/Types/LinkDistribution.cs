namespace Azure.DevOps.Notificator.Types;

public class LinkDistribution
{
	public Link Self { get; set; }

	public Link WorkItemUpdates { get; set; }

	public Link WorkItemRevisions { get; set; }

	public Link WorkItemType { get; set; }

	public Link Html { get; set; }

	public Link WorkItemHistory { get; set; }

	public Link Fields { get; set; }
}