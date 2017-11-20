using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cars
{
    class Employees
    {
        int ID;
        string name;
        double meetTime;
        Assignments assignment;

        public Employees(int id, string name, double meetTime)
        {
            ID = id;
            this.name = name;
            this.meetTime = meetTime;
        }

        public int GetEmpID()
        {
            return ID;
        }
    }
}
