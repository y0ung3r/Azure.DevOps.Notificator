namespace Azure.DevOps.Notificator.Types;

public class Revision
{
	public long? Id { get; set; }

	public long? Rev { get; set; }

	public FieldDistribution Fields { get; set; }

	public Uri Url { get; set; }
}