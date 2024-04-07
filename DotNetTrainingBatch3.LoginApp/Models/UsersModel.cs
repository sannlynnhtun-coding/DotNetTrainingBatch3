using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DotNetTrainingBatch3.LoginApp.Models
{
    [Table("Tbl_Users")]
    public class UsersModel
    {
        [Key]
        public string UserId { get; set; }
        //[Column("BlogTitle")]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
