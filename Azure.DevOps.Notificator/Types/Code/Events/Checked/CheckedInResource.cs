namespace Azure.DevOps.Notificator.Types.Code.Events.Checked;

public class CheckedInResource : Resource
{
    public Author Author { get; set; }

    public Author CheckedInBy { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }

    public string Comment { get; set; }
}