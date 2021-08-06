namespace CompanyAnalysis.Models
{
    public interface IAssetСalculator
    {
        decimal CalculateMarketCap(IAssets company);
    }
}
