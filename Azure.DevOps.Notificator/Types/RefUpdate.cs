namespace Azure.DevOps.Notificator.Types;

public class RefUpdate
{
    public string Name { get; set; }

    public string OldObjectId { get; set; }

    public string NewObjectId { get; set; }
}