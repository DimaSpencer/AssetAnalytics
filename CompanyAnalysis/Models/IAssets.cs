namespace CompanyAnalysis.Models
{
    public interface IAssets
    {
        //общее количество имеющегося актива в мире
        long Count { get; set; }
        //текущая цена актива
        decimal Price { get; set; }
    }
}
