using System.Data;
using System.Data.SqlClient;
using DotNetTrainingBatch3.ConsoleApp.AdoDotNetExamples;
using DotNetTrainingBatch3.ConsoleApp.DapperExamples;
using DotNetTrainingBatch3.ConsoleApp.EFCoreExamples;
using DotNetTrainingBatch3.ConsoleApp.HttpClientExamples;
using DotNetTrainingBatch3.ConsoleApp.Models;
using DotNetTrainingBatch3.ConsoleApp.RestClientExamples;
using Newtonsoft.Json;

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

//DapperExample dapperExample = new DapperExample();
//dapperExample.Read();

//dapperExample.Edit(1);
//dapperExample.Edit(11);

//dapperExample.Create("test title", "test author", "test content");
//dapperExample.Update(2002, "test title 2", "test author 2", "test content 2");
//dapperExample.Delete(2002);

//EFCoreExample efCoreExample = new EFCoreExample();
//efCoreExample.Read();

//efCoreExample.Edit(1);
//efCoreExample.Edit(11);

//efCoreExample.Create("test title", "test author", "test content");
//efCoreExample.Update(3002, "test title 2", "test author 2", "test content 2");
//efCoreExample.Delete(3002);

//Console.WriteLine("Waiting for api...");
//Console.ReadKey();

//HttpClientExample httpClientExample = new HttpClientExample();
//await httpClientExample.Run();

//BlogModel blog = new BlogModel();
//blog.BlogTitle = "Test";
//blog.BlogAuthor = "Test";
//blog.BlogContent = "Test";

//string json = JsonConvert.SerializeObject(blog); // C# object to Json
//Console.WriteLine(blog);
//Console.WriteLine(json);
//Console.WriteLine(blog.BlogTitle);
//Console.WriteLine(blog.BlogAuthor);
//Console.WriteLine(blog.BlogContent);

//BlogModel blog2 = JsonConvert.DeserializeObject<BlogModel>(json)!;
//Console.WriteLine(blog2.BlogTitle);
//Console.WriteLine(blog2.BlogAuthor);
//Console.WriteLine(blog2.BlogContent);
//// hello

Console.WriteLine("Waiting for api...");
Console.ReadKey();

//HttpClientExample httpClientExample = new HttpClientExample();
//await httpClientExample.Run();

RestClientExample restClientExample = new RestClientExample();
await restClientExample.Run();

Console.ReadKey();
