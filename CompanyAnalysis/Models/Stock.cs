namespace CompanyAnalysis.Models
{
    public class Stock : IAssets
    {
        public long Count { get; set; }
        public decimal Price { get; set; }
    }
}
