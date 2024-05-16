public class ContentDistribution
{
    public DateTime DistributionDate { get; set; }
    public string DistributionChannel { get; set; }
    public string DistributionMethod { get; set; }
    public List<Asset> Assets { get; set; }
}