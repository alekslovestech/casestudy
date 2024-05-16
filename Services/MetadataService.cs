public interface IMetadataService
{
    Task<Asset> GetAssetByIdAsync(string assetId);
    Task<List<Asset>> GetAllAssetsAsync();
    Task<Order> GetOrderByNumberAsync(string orderNumber);
    Task<ContentDistribution> GetDistributionByDateAsync(DateTime distributionDate);
    Task<List<Briefing>> GetAllBriefingsAsync();
}

public class MetadataService : IMetadataService
{
    // Implement methods to read from database and link metadata
}