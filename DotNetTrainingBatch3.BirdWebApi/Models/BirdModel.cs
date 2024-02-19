namespace DotNetTrainingBatch3.BirdWebApi.Models
{
    public class BirdDataModel
    {
        public int Id { get; set; }
        public string BirdMyanmarName { get; set; }
        public string BirdEnglishName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }

    public class BirdViewModel
    {
        public int BirdId { get; set; }
        public string BirdName { get; set; }
        public string Desp { get; set; }
        public string PhotoUrl { get; set; }
    }

    // ViewModel
    // DataModel
}
