using System.Data;
using System.Data.SqlClient;
using DotNetTrainingBatch3.ConsoleApp.AdoDotNetExamples;
using DotNetTrainingBatch3.ConsoleApp.DapperExamples;

Console.WriteLine("Hello, World!");

// F5 => Run

// Ctrl + K, C => Disable
// Ctrl + K, C => Enable

//Console.ReadLine();

// Ctrl + .
// F9 => Break point
// Shift + F5 => Stop 

// UI, BL, DA => SQL

// CRUD

// ntier three tier

// Kpay
// Tranfer
// from mobile no
// to mobile no
// amount
// passcode

// mobile no (-1000)
// mobile no (+1000)
// from to +1000 date

//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = ".";
//sqlConnectionStringBuilder.InitialCatalog = "TestDb";
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "sasa@123";

//Console.WriteLine("ConnectionString => " + sqlConnectionStringBuilder.ConnectionString);

//SqlConnection connection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
//Console.WriteLine("Connection Opening...");
//connection.Open();  
//Console.WriteLine("Connection Opened...");

//// data set
//// data table
//// data row
//// data column

//string query = @"SELECT [BlogId]
//      ,[BlogTitle]
//      ,[BlogAuthor]
//      ,[BlogContent]
//  FROM [dbo].[Tbl_Blog]";
//SqlCommand cmd = new SqlCommand(query, connection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//adapter.Fill(dt);

//Console.WriteLine("Connection Closing...");
//connection.Close();
//Console.WriteLine("Connection Closed...");

//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine("Title..." + dr["BlogTitle"]);
//    Console.WriteLine("Author..." + dr["BlogAuthor"]);
//    Console.WriteLine("Content..." + dr["BlogContent"]);
//}

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
////adoDotNetExample.Read();
////adoDotNetExample.Edit(1);
////adoDotNetExample.Edit(11);
////adoDotNetExample.Create("test title", "test author", "test content");
//adoDotNetExample.Update(1002, "test title 2", "test author 2", "test content 2");
////adoDotNetExample.Update(1002, content: "test title 2", author: "test author 2", title: "test content 2");
//adoDotNetExample.Delete(1002);

DapperExample dapperExample = new DapperExample();
//dapperExample.Read();

//dapperExample.Edit(1);
//dapperExample.Edit(11);

//dapperExample.Create("test title", "test author", "test content");
//dapperExample.Update(2002, "test title 2", "test author 2", "test content 2");
dapperExample.Delete(2002);

// hello

Console.ReadKey();
