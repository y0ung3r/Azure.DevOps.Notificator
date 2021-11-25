namespace Azure.DevOps.Notificator.Types;

public class FieldDistribution
{
	public string SystemAreaPath { get; set; }

	public string SystemTeamProject { get; set; }

	public string SystemIterationPath { get; set; }

	public string SystemWorkItemType { get; set; }

	public string SystemState { get; set; }

	public string SystemReason { get; set; }

	public DateTimeOffset? SystemCreatedDate { get; set; }

	public string SystemCreatedBy { get; set; }

	public DateTimeOffset? SystemChangedDate { get; set; }

	public string SystemChangedBy { get; set; }

	public string SystemTitle { get; set; }

	public string MicrosoftAzureDevOpsServicesCommonSeverity { get; set; }

	public string SystemHistory { get; set; }
}