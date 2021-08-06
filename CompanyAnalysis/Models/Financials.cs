using System.Collections.Generic;

namespace CompanyAnalysis.Models
{
    public class Financials
    {
        public Stock Stock { get; set; }

        private List<CompanyReport> _companyReports = new List<CompanyReport>();
        public IReadOnlyCollection<CompanyReport> CompanyReports => _companyReports.AsReadOnly();

        public void AddReport(CompanyReport report)
        {
            _companyReports.Add(report);
        }
    }
}
