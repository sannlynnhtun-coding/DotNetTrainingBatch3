# .NET Training Batch 3

https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx
https://learn.microsoft.com/en-us/ef/core/cli/dotnet

dotnet tool install --global dotnet-ef 7.0.17

 Scaffold-DbContext "Server=.;Database=TestDb;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Context AppDbContext -Tables Tbl_PieChart

 Scaffold-DbContext "Server=.;Database=TestDb;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir EfCoreDataModels -Context AppDbContext -Tables Tbl_PieChart

 dotnet ef dbcontext scaffold "Server=.;Database=TestDb;User ID=sa;Password=sasa@123;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o EfCoreDataModels -c AppDbContext -t Tbl_PieChart

```sql

CREATE TABLE [dbo].[Tbl_Atm](
	[AtmId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[CardNumber] [nvarchar](50) NOT NULL,
	[Balance] [decimal](20, 2) NOT NULL,
 CONSTRAINT [PK_Tbl_Atm] PRIMARY KEY CLUSTERED 
(
	[AtmId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

```

MVC
Model View Controller

Controller View(model - dto)

https://code.visualstudio.com/download

https port - 443
http port - 80

mssql port - 1433

Node.js
https://www.youtube.com/watch?v=zb3Qk8SG5Ms&list=PL4cUxeGkcC9jsz4LDYc6kv3ymONOKxwBU

JSON Server
https://www.youtube.com/watch?v=mAqYJF-yxO8&t=15s
https://www.youtube.com/watch?v=VF3TI4Pj_kM

Express.js
https://youtu.be/nH9E25nkk3I?si=5J4kCb3v28LW3uYD

React.js
https://www.youtube.com/watch?v=j942wKiXFu8&list=PL4cUxeGkcC9gZD-Tvwfod2gaISzfRiP9d

React.js Crud using JSON placeholder
https://youtu.be/Zhmuc_NFiO8?si=pAH5XDnoDpcHz8X7

https://github.com/reactiveui/refit
https://restsharp.dev/

![Alt text](https://uxdworld.com/wp-content/uploads/2018/12/pagination-1.gif)

Visual Studio 2022 Preview
https://visualstudio.microsoft.com/vs/preview/

Ajax CRUD
https://dev.to/duhbhavesh/how-to-use-fetch-api-for-crud-operations-57a0

fetch
axios

- [x] Console App

- [x] Ado.Net (CRUD)
- [x] Dapper  (CRUD)
- [x] EF Entity Framework (Code First => Create Table, Database First => use in Code) (CRUD)
- RepoDB

- [x] Postman
- [x] Asp.Net Core Web Api (Rest Api)
    - [x] EF
    - Dapper
    - Ado.Net
    
- [x] Console App connect with ASP.NET Core Web API
    - [x] HttpClient
    - [x] RestClient
    - [x] Refit

- [x] Burma Project Ideas(Bird)

- [x] html, css, javascript
- [x] bootstrap
- [x] jquery
- [x] jquery plugins
    - [x] sweetalert https://sweetalert2.github.io/
    - [x] notiflix https://notiflix.github.io/ Notify Report Confirm Loading Block
    - [x] datatable https://datatables.net/examples/index https://datatables.net/ https://datatables.net/download/
    - [x] datetime picker https://fengyuanchen.github.io/datepicker/ https://github.com/fengyuanchen/datepicker/blob/master/README.md https://github.com/fengyuanchen/datepicker/releases/tag/v1.0.10
    - [x] ladda button https://cdnjs.com/libraries/ladda-bootstrap https://msurguy.github.io/ladda-bootstrap/ https://github.com/msurguy/ladda-bootstrap
    - [x] radio checkbox https://bantikyan.github.io/icheck-bootstrap/ https://cdnjs.com/libraries/icheck-bootstrap https://github.com/bantikyan/icheck-bootstrap https://penguin-arts.com/how-to-check-if-a-checkbox-is-checked-using-icheck-library/
    - [x] toast https://apvarun.github.io/toastify-js/# https://github.com/apvarun/toastify-js/blob/master/README.md
    - [x] Chart [ApexChart]

- [x] Asp.Net Core MVC (submit, ajax)
    - [x] EF 
    - [x] Ado.Net
    - [x] Dapper

- APS.NET Core MVC using JavaScript Chart
    - [x] [ApexChart](http://apexcharts.com/docs/installation/)
    - [x] [ChartJs](https://www.chartjs.org/docs/latest/getting-started/) (https://github.com/chartjs/Chart.js/blob/master/docs/scripts/utils.js)
    - [x] [HighCharts](https://www.highcharts.com/demo)
    - [x] [CanvasJS](https://canvasjs.com/javascript-charts/)

- [x] ASP.NET Core - Dependency Injection
    - [x] Singleton
    - [x] Scoped
    - [x] Transient

- [x] AdoDotNetService
- [x] DapperService

------------------------------------------------------

- [x] Api Call [MVC]
    - [x] HttpClient
    - [x] RestClient
    - [x] Refit

- [x] Minimal Api

- [x] Logging (Console App, Web Api)
    - [x] [Serilog](https://serilog.net/)
        - [x] Text Logging
        - [x] Db Logging
    - NLog
    - Log4net
    
- [x] Realtime Chat Message using SignalR
- [x] UI Design
- [x] Deploy on IIS 

- [x] Realtime Chart App using SignalR 
- Middleware For MVC
- Blazor CRUD [Server, WASM]
- Deploy WASM

------------------------------------------------------

- GraphQL
- gRPC

------------------------------------------------------

https://stackedit.io/app#

https://www.openapis.org/

https://developer.mozilla.org/en-US/docs/Web/HTTP/Status
```
Informational responses (100 – 199)
Successful responses (200 – 299)
Redirection messages (300 – 399)
Client error responses (400 – 499)
Server error responses (500 – 599)
```

![image info](https://media.geeksforgeeks.org/wp-content/uploads/20230216170349/What-is-an-API.png)

https://stackoverflow.com/questions/17615260/the-certificate-chain-was-issued-by-an-authority-that-is-not-trusted-when-conn

https://www.javatpoint.com/ado-net-tutorial

ado.net CRUD
dapper
ef core (code first, database first)

C#

.net framework (windows)
1
2
3
4
4.5
4.6
4.7
4.8

.net core (windows, linux, macos)
1
2
2.2
3
3.1

.net (windows, linux, macos) 
5 (vs2019, vs2022)
6 (vscode, vs2022)
7 (current)
8
9 (beta)

- console app [x]
- windows forms
- asp.net web forms
- asp.net core web mvc [x]
- asp.net core web api [x]

https://www.c-sharpcorner.com/article/introduction-to-nlog-with-asp-net-core2/
https://code-maze.com/aspnetcore-structured-logging-log4net/