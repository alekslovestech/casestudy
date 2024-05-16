public class Order
{
    public string OrderNumber { get; set; }
    public string CustomerName { get; set; }
    public DateTime OrderDate { get; set; }
    public List<OrderAsset> Assets { get; set; }
}