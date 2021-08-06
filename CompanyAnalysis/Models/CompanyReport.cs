using System;

namespace CompanyAnalysis.Models
{
    public class CompanyReport
    {
        public DateTime Date { get; set; }

        //Общий доход
        public long TotalRevenue { get; set; }
        //Валовая прибыль
        public long GrossProfit { get; set; }
        //операционна прибыль
        public long OperatingIncome { get; set; }
        //чистая прибыль
        public long NetIncome { get; set; }
    }
}
