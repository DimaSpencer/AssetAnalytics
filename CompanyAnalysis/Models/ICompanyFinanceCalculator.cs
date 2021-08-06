namespace CompanyAnalysis.Models
{
    public interface ICompanyFinanceCalculator
    {
        decimal CalculateEPS(Company company);
        decimal CalculatePE(Company company);
    }
}
