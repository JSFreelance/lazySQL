using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;

namespace lazySQL
{
    class dbConfig
    {

        private StringBuilder queryStr;
        private String[] connectionSettings;

        //dbConfig Constructor, it receives the connection settings: host, db, port, user, password
        public dbConfig(params String[] connectionSettings)
        {
            //Adds all connection settings to 
            this.connectionSettings = new string[4];
            for (int i = 0; i < connectionSettings.Length; i++)
            {
                this.connectionSettings[i] = connectionSettings[i];
            }

            queryStr = new StringBuilder();

        }

        public dbConfig Select(params String[] fields)
        {

            queryStr.Append("Select ");

            foreach (string field in fields)
            {
                if (field == fields[fields.Length - 1])
                {
                    queryStr.Append(field);

                } else{

                    queryStr.Append(field);
                    queryStr.Append(",");
                }
            }
            
            return this;
        }

        public dbConfig From(params String[] tables)
        {
            queryStr.Append(" From ");

            foreach (string table in tables)
            {
                if (table == tables[tables.Length - 1])
                {
                    queryStr.Append(table);

                } else{

                    queryStr.Append(table);
                    queryStr.Append(",");
                }
            }
            
            return this;
        }

        public dbConfig Where(string boolExp)
        {
            queryStr.Append(" Where ");
            queryStr.Append(boolExp);
            
            return this;
        }

        public resultSet<Object> Start()
        {
            queryStr.Append(";");
            Connection<Object> conn = new Connection<object>(connectionSettings);
            Console.WriteLine(queryStr);
            return  conn.getSelect(queryStr.ToString());
            
        }
    }
}
