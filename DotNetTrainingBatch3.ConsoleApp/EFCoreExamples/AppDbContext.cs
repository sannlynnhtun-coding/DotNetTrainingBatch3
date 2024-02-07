using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetTrainingBatch3.ConsoleApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DotNetTrainingBatch3.ConsoleApp.EFCoreExamples
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "TestDb",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<BlogModel> Blogs { get; set; }
    }
}
