namespace Azure.DevOps.Notificator.Types.Events.Code.Checked;

public class CodeCheckedInResource : Resource
{
    public Author Author { get; set; }

    public Author CheckedInBy { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }

    public string Comment { get; set; }
}