namespace DotNetTrainingBatch3.MvcApp.Models
{
    public class ApexChartDashedLineModel
    {
        public string name { get; set; }
        public List<int> data { get; set; }
    }

    public class ApexChartDashedLineResponseModel
    {
        public List<ApexChartDashedLineModel> Series { get; set; }
        public List<string> Lables { get; set; }
    }
}
