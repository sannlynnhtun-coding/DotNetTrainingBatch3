using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetTrainingBatch3.MvcApp.Models;

[Table("Tbl_PageStatistics")]
public class PageStatisticsModel
{
    [Key]
    public int PageStatisticsId { get; set; }
    public int SessionDuration { get; set; }
    public int PageViews { get; set; }
    public int TotalVisits { get; set; }
    public string CreatedDate { get; set; }
}