
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
}
