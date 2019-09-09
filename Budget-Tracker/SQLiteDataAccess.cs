﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Tracker
{
    public class SQLiteDataAccess
    {
        public static List<expenseModel> loadExpenses()
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                var output = cnn.Query<expenseModel>("select * from expenseTable", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void saveExpenses(expenseModel expense)
        {
            using (IDbConnection cnn = new SQLiteConnection(loadConnectionString()))
            {
                cnn.Execute("insert into expenseTable (Name, Amount, Date) values (@Name, @Amount, @Date)", expense);
            }
        }

        public static string loadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
