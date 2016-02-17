using System;
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
