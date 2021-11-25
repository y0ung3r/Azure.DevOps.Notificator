using Azure.DevOps.Notificator.Types.Events.Code.Checked;

namespace Azure.DevOps.Notificator.Types.Events.Code;

public class CodePushed
{
    public Guid? Id { get; set; }

    public string EventType { get; set; }

    public string PublisherId { get; set; }

    public string Scope { get; set; }

    public Message Message { get; set; }

    public Message DetailedMessage { get; set; }

    public CodeCheckedInResource Resource { get; set; }

    public string ResourceVersion { get; set; }

    public ResourceDistribution ResourceDistribution { get; set; }

    public DateTimeOffset? CreatedDate { get; set; }
}