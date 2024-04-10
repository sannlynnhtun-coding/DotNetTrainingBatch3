using DotNetTrainingBatch3.LoginApp.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.LoginApp
{
    public class AppDBContext : DbContext
    {
        //public AppDBContext(DbContextOptions options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder OptionBuilder)
        {
            //SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            //{
            //    DataSource = @".\SQL2019E",
            //    InitialCatalog = "TestDB",
            //    UserID = "sa",
            //    Password = "p@ssw0rd",
            //    TrustServerCertificate = true
            //};
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = @".",
                InitialCatalog = "TestDB",
                UserID = "sa",
                Password = "sasa@123",
                TrustServerCertificate = true
            };
            OptionBuilder.UseSqlServer(sqlConnectionStringBuilder.ConnectionString);
        }

        public DbSet<UsersModel> Users { get; set; }
        public DbSet<LoginModel> Login { get; set; }
    }
}
