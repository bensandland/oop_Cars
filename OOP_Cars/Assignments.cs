using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Cars
{
    public class Assignments
    {
        int empID;
        Employees employee;
        string assName;
        double estTime;

        public int GetID()
        {
            return empID;
        }

        public string GetAssName()
        {
            return assName;
        }

        public double GetEstTime()
        {
            return estTime;
        }

        public int GetEmpID()
        {
            return employee.GetEmpID();
        }

        public Assignments(string assName, double estTime)
        {
            this.assName = assName;
            this.estTime = estTime;
        }
    }
}
