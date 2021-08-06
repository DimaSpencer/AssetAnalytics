using System.Text;

namespace CompanyAnalysis.Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Ticker { get; set; }

        public Financials Financials { get; set; }
    }
}
