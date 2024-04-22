using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch3.LoginAppV2.EFDbContext;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<UsersModel> Users { get; set; }
    public DbSet<LoginModel> Login { get; set; }
}

[Table("Tbl_Login")]
public class LoginModel
{
    [Key]
    public int Id { get; set; }
    public string UserId { get; set; }
    public string SessionId { get; set; }
    public DateTime SessionExpired { get; set; }

}

[Table("Tbl_User")]
public class UsersModel
{
    [Key]
    public string UserId { get; set; }
    //[Column("BlogTitle")]
    public string UserName { get; set; }
    public string Password { get; set; }
}
