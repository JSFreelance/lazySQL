using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lazySQL
{
    public class resultSet<T>
    {


        public List<T> fieldsList { get; set; }
        public List<List<T>> RowList { get; set; }

        public resultSet()
        {
            RowList = new List<List<T>>();
        }

    }
}
