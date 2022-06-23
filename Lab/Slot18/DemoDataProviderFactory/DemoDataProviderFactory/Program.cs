using System;
using System.Data.Common;
using System.IO;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
namespace DemoDataProviderFactory
{
    class Program
    {   


        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", true, true)
                                .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
        }
        static void ViewProducts()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            //get connection object
            using DbConnection connection = factory.CreateConnection();
            if (connection == null)
            {
                Console.WriteLine($"Unable to create the connection object");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            
            //make command  object 
            DbCommand command = factory.CreateCommand();
            if (command == null)
            {
                Console.WriteLine($"Unable to create the command object");
                return;
            }
            command.Connection = connection;
            command.CommandText = "select ProductID,ProductName from Products ";
            //print out data with data reader
            using DbDataReader dataReader = command.ExecuteReader();
            Console.WriteLine("*****HIHIHI*****");
            while (dataReader.Read())
            {
                Console.WriteLine($"ID:{dataReader["ProductID"]} Name:{dataReader["ProductName"]}");
            }
        }
        static void Main(string[] args)
        {
            ViewProducts();
            Console.ReadLine();
        }
    }
}
