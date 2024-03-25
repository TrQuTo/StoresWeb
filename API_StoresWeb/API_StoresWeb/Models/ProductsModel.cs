namespace API_StoresWeb.Models
{
    public class ProductsModel
    {
        public Guid ID { get; set; }
        public required string ProCode { get; set; }
        public string? ProName { get; set; }
    }
}
