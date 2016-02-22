
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Npgsql;

namespace lazySQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example using select: Select id, user_id from tweet where user_id = 1;

            //Init db config: host, db, user, password
            dbConfig db = new dbConfig("your_host", "your_db", "your_user","your_pasword");
            resultSet<Object> rs = db.Select("id", "user_id").From("tweet").Where("user_id = 1").Start();

            foreach (List<Object> l in rs.RowList)
            {
                foreach (Object o in l)
                {
                    Console.Write(o); Console.Write("-");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
