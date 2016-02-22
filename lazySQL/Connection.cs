<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace lazySQL
{
    class Connection<T>
    {

        StringBuilder connString = new StringBuilder();
        resultSet<T> rs;
        List<T> row;

        public Connection(string[] connSettings)
        {
            connString.Append(" Server=");
            connString.Append(connSettings[0]);
            connString.Append("; Database=");
            connString.Append(connSettings[1]);
            connString.Append("; User Id=");
            connString.Append(connSettings[2]);
            connString.Append("; Password=");
            connString.Append(connSettings[3]);
        }

        public resultSet<T> getSelect(string queryStr)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString.ToString()))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(queryStr, conn);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                //get Num columns:
                int nColumns = dataReader.FieldCount;
                rs = new resultSet<T>();

                while (dataReader.Read())
                {
                    row = new List<T>();
                    for (int i = 0; i < nColumns; i++)
                    {
                        row.Add((T)dataReader[i]);
                    }
                    rs.RowList.Add(row);
                }
            }
            return rs;

        }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace lazySQL
{
    class Connection<T>
    {
        string host = ConfigurationSettings.AppSettings["host"];
        string user = ConfigurationSettings.AppSettings["user"];
        string password = ConfigurationSettings.AppSettings["password"];
        string db = ConfigurationSettings.AppSettings["db"];
        StringBuilder connString = new StringBuilder();
        resultSet<T> rs;
        List<T> row;

        public Connection()
        {
            connString.Append(host);
            connString.Append(user);
            connString.Append(password);
            connString.Append(db);
        }

        public resultSet<T> getSelect(string queryStr)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connString.ToString()))
            {
                conn.Open();
                NpgsqlCommand command = new NpgsqlCommand(queryStr, conn);
                NpgsqlDataReader dataReader = command.ExecuteReader();

                //get Num columns:
                int nColumns = dataReader.FieldCount;
                rs = new resultSet<T>();

                while (dataReader.Read())
                {
                    row = new List<T>();
                    for (int i = 0; i < nColumns; i++)
                    {
                        row.Add((T)dataReader[i]);
                    }
                    rs.RowList.Add(row);
                }
            }
            return rs;

        }
    }
>>>>>>> 2c37c2b23ef6cc05e6bffe4cb21e01e9d6b9658b
}