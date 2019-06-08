using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byd001_app
{
    class common
    {
        private static string id;
        private static string name;

        public static string ID
        {
            get { return id; }
            set { id = value; }
        }
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
