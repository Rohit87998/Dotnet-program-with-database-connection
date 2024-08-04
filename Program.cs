using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using MyApp.Models;
using Practice.Data;
namespace MyApp
{   
  class Program
    {
        Program()
        {
            System.Console.WriteLine("object created");
        }
        static void Main(string[] args)
        {
            
              //sql connection object is for microsoft sql server and the IDbConnection is a general object for database connection.
           DataContextDapper Dapperobj = new DataContextDapper();
           DateTime rightnow = Dapperobj.QuerySingle<DateTime>("Select getDate()");
           System.Console.WriteLine(rightnow);
           Commputer computer = new Commputer(){
            MotherBoard = "xZ687",
            cores = 100,
            HasWifi= true,
            HasLte=true,
            date = DateTime.Now,
            price = 1000.23M,
            VideoCard = "Rtx 4090"
            };
           string sql = @"INSERT INTO TutorialAppSchema.Computer (
           Motherboard,
           CPUcores,
           HasWifi,
           HasLTE,
           ReleaseDate,
           Price,
           Videocard
           ) VALUES ('" + computer.MotherBoard
           + "','" + computer.cores
           + "','" + computer.HasWifi
           + "','" + computer.date   
           + "','" + computer.price
           + "','" + computer.VideoCard
           + "')"; 
          Dapperobj.ExecuteSql(sql);  
        }
        
     }
} 