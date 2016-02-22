<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
>>>>>>> 2c37c2b23ef6cc05e6bffe4cb21e01e9d6b9658b
