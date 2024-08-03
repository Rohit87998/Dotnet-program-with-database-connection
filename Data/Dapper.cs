using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Practice.Data
{
    public class DataContextDapper 
    {
        private string _connectionString = "Server=localhost;Database=DotnetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true;";
        public IEnumerable<T> LoadData<T>(string sql)
        {
            IDbConnection connection = new SqlConnection(_connectionString);
            return connection.Query<T>(sql);
            
        }
        public T QuerySingle <T>(string sql)
        {
            IDbConnection connection = new SqlConnection(_connectionString);
            return connection.QuerySingle<T>(sql);
            
        }
          public T LoadDataSingle<T>(string sql)
        {
            IDbConnection connection = new SqlConnection(_connectionString);
            return connection.QuerySingle<T>(sql);
            
        }

          public bool ExecuteSql (string sql)
        {
            IDbConnection connection = new SqlConnection(_connectionString);
            return connection.Execute(sql)>0;
            
        }

         public int ExecuteSqlwithRowCount (string sql)
        {
            IDbConnection connection = new SqlConnection(_connectionString);
            return connection.Execute(sql);
            
        }
    }
}