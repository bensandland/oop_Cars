using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cars
{
    public class Calender
    {
        public string name { get; set; }

        public List<Employee> Employees { get; set; }

        public List<Assignment> Assignments { get; set; }

        public List<Cars> Cars { get; set; }

        public int empId { get; set; }

        public Calender()
        {
            Employees = new List<Employee>();
            Assignments = new List<Assignment>();
            Cars = new List<Cars>();
            empId = 0;

        }
    }
}
