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
    Task<Asset> GetAssetByIdAsync(string assetId)
    {
        //Read the JSON file into an asset array => Deserialize the JSON content.
        // OR 
        // Query the database to get the asset by its ID
        // OR
        // Query the CMS to get the asset by its ID

        // Find and return the asset by its ID
        const _filePath = "../Metadata/AssetMetadata.json";
        using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
        {
            var assets = await JsonSerializer.DeserializeAsync<List<Asset>>(stream);
            return assets?.FirstOrDefault(asset => asset.AssetId == assetId);
        }
    }
}