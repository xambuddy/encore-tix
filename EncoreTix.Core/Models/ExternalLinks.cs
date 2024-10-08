namespace EncoreTix.Core.Models;

public class ExternalLinks
{
    public IEnumerable<ExternalLink> Youtube { get; set; }

    public IEnumerable<ExternalLink> Twitter { get; set; }

    public IEnumerable<ExternalLink> Facebook { get; set; }

    public IEnumerable<ExternalLink> Instagram { get; set; }

    public IEnumerable<ExternalLink> Homepage { get; set; }
}

public class ExternalLink
{
    public string Url { get; set; }
}