using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public static class SKClass
    {
        public static string GetConnectionString()
        {
            string Connection = Environment.GetEnvironmentVariable("SK_CONNECTION");           
            if (!string.IsNullOrEmpty(Connection))
            {
                return Connection;
            }
            else
            {
                throw new InvalidOperationException("Environemnt variable 'SK_CONNECTION' is not set");
            }
        }
    }
}
