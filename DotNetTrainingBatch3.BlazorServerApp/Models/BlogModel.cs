using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNetTrainingBatch3.BlazorServerApp.Models
{
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
}
