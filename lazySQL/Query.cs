using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lazySQL
{
    class Query
    {
        private String[] param;
        private String[] tables;

        public Query Select(params String[] param)
        {
            this.param = this.param;
            return this;
        }

        public void from(params String[] tables)
        {
            this.tables = this.tables;


        }


        public resultSet<Object> launch()
        {
            return new Connection<Object>().getSelect("");
        }

        public String parseSelect()
        {
            String output = "SELECT";


            return "";
        }
    }
}
