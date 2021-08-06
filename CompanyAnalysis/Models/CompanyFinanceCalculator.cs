using System.Linq;

namespace CompanyAnalysis.Models
{
    public class CompanyFinanceCalculator : ICompanyFinanceCalculator
    {
        public decimal CalculateEPS(Company company)
        {
            decimal sharePrice = company.Financials.Stock.Price;
            long netIncome = company.Financials.CompanyReports.Last().NetIncome;

            return netIncome / sharePrice;
        }

        public decimal CalculateMarketCap(IAssets asset)
        {
            return asset.Price * asset.Count;
        }

        public decimal CalculatePE(Company company)
        {
            decimal currentMarketCap = CalculateMarketCap(company.Financials.Stock);
            decimal PE = currentMarketCap / company.Financials.Stock.Price;
            return PE;
        }
    }
}
