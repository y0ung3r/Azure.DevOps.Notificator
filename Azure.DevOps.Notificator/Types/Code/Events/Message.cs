using Newtonsoft.Json;

namespace Azure.DevOps.Notificator.Types.Code.Events;

public class Message
{
    [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
    public string Text { get; set; }

    [JsonProperty("html", NullValueHandling = NullValueHandling.Ignore)]
    public string Html { get; set; }

    [JsonProperty("markdown", NullValueHandling = NullValueHandling.Ignore)]
    public string Markdown { get; set; }
}