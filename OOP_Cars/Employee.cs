using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cars
{
    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public double meetTime { get; set; }
                

        public string Display
        {
            get
            {
                return string.Format("{0} - {1}", ID, name);
            }
        }

    }
}
