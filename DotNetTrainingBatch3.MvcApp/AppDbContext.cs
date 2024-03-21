using DotNetTrainingBatch3.MvcApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch3.MvcApp;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //    SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
    //    {
    //        DataSource = ".",
    //        InitialCatalog = "TestDb",
    //        UserID = "sa",
    //        Password = "sasa@123",
    //        TrustServerCertificate = true
    //    };
    //    optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
    //}

    public DbSet<BlogModel> Blogs { get; set; }

    public DbSet<PageStatisticsModel> PageStatistics { get; set; }

    public DbSet<RadarModel> Radars { get; set; }
}