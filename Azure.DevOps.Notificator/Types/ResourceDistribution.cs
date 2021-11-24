namespace Azure.DevOps.Notificator.Types;

public class ResourceDistribution
{
	public Account Collection { get; set; }

	public Account Account { get; set; }

	public Account Project { get; set; }
}