<<<<<<< HEAD
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
    class Program
    {
        static void Main(string[] args)
        {

            // Output rows
            /*
             while (dr.Read())
                 Console.Write("{0}\t{1} \n", dr[0], dr[1]);

             String query = "SELECT * FROM users";
             
             Connection<Object> c = new Connection<Object>();
             resultSet<Object> rs = c.getSelect(query);

            foreach (List<Object> ls in rs.RowList)
            {
                foreach (Object i in ls)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }*/

            Query q = new Query();
            q.Select("id", "name").from("users");


            Console.ReadLine();

        }
    }
}
>>>>>>> 2c37c2b23ef6cc05e6bffe4cb21e01e9d6b9658b
