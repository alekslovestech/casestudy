[ApiController]
[Route("api/metadata")]
public class MetadataController : ControllerBase
{
    private readonly IMetadataService _metadataService;

    public MetadataController(IMetadataService metadataService)
    {
        _metadataService = metadataService;
    }

    [HttpGet("asset/{id}")]
    public async Task<IActionResult> GetAsset(string id)
    {
        var asset = await _metadataService.GetAssetByIdAsync(id);
        if (asset == null)
        {
            return NotFound();
        }
        return Ok(asset);
    }

    [HttpGet("order/{orderNumber}")]
    public async Task<IActionResult> GetOrder(string orderNumber)
    {
        var order = await _metadataService.GetOrderByNumberAsync(orderNumber);
        if (order == null)
        {
            return NotFound();
        }
        return Ok(order);
    }

    [HttpGet("distribution/{date}")]
    public async Task<IActionResult> GetDistribution(DateTime date)
    {
        var distribution = await _metadataService.GetDistributionByDateAsync(date);
        if (distribution == null)
        {
            return NotFound();
        }
        return Ok(distribution);
    }

    [HttpGet("briefings")]
    public async Task<IActionResult> GetBriefings()
    {
        var briefings = await _metadataService.GetAllBriefingsAsync();
        return Ok(briefings);
    }
}