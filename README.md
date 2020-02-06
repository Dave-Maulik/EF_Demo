# EF_Demo
An Simple Application Using EF and LINQ Queries ASp.net (c#)

## EF6 (Entity Framework)
Entity Framework 6 (EF6) is a tried and tested object-relational mapper (O/RM) for .NET with many years of feature development and stabilization.
[for more](https://docs.microsoft.com/en-us/ef/ef6/)

## Changes to Done Before Execution.
Get the Connection String of your local_server and Paste it into the web.config File.
You can find it in the Project>Web.config
```XML
 <connectionStrings>
    <add name="EmployeeDbContext" connectionString="Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True" providerName="System.Data.SqlClient"/>
  </connectionStrings>
```
attributes : name = "Your DBContext Class name"
connectionString  = "connection string of your server"
Integrated Security=True (There is no need of username and password to access the database server).


## For Error **Could not find a part of the path 'E:\sitesroot\0\bin\roslyn\csc.exe'.** 

[link to Fix!](https://docs.microsoft.com/en-us/archive/blogs/jpsanders/error-could-not-find-a-part-of-the-path-esitesroot0binroslyncsc-exe)

![Screenshot (3)](https://user-images.githubusercontent.com/60167341/73818658-dac2cf00-4813-11ea-9ac1-e9142ae1708b.png)
