using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetTrainingBatch3.MvcApp.Models;

[Table("Tbl_Blog")]
public class BlogModel
{
    [Key]
    //[Column("BlogId")]
    public int BlogId { get; set; }
    public string BlogTitle { get; set; }
    public string BlogAuthor { get; set; }
    public string BlogContent { get; set; }
}

public class BlogMessageResponseModel
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}

[Table("Tbl_RadarChart")]
public class RadarModel
{
    [Key]
    public int Id { get; set; }
    public string Month { get; set; }
    public int Series { get; set; }
}

public class ApexChartRadarResponseModel
{
    public List<int> Series { get; set; }
    public List<string> Lables { get; set; }
}