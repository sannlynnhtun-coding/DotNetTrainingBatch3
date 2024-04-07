using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using DotNetTrainingBatch3.BlazorServerApp.Models;

namespace DotNetTrainingBatch3.BlazorServerApp;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<BlogModel> Blogs { get; set; }
}