using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Ex_1
{
    class Employees
    {

        public string name;
        public string dateOfHire;
        public double monthlySalary;
        public double yearlySalary;
        public string number;




        //this is a constructor
        public Employees(string iName, string idateOfHire, double imonthlySalary, string iNumber, double iyearlySalary)
        {
            name = iName;
            dateOfHire = idateOfHire;
            monthlySalary = imonthlySalary;
            number = iNumber;
            yearlySalary = iyearlySalary;
            
        }



        //this is a constructor with two fields
        public Employees(string iName, double imonthlySalary)
        {
            name = iName;
            monthlySalary = imonthlySalary;
        }

        //this is a constructor with no fields
        public Employees()
        {

        }

        public string getName()
        { return this.name; }
        public void setName(string n)
        { this.name = n; }


        public string getdateOfHire()
        { return this.dateOfHire; }
        public void setdateOfHire(string dOH)
        { this.dateOfHire = dOH; }
        

        public double getmonthlySalary()
        { return this.monthlySalary; }
        public void setmonthlySalary(double mSalary)
        { this.monthlySalary = mSalary; }
        
        
        //this is monthly salary * 12 = year
        public double iyearlySalary(double monthlySalary)
        {
            yearlySalary = monthlySalary * 12;
            return yearlySalary;
        }

        public double getyearlySalary()
        { return this.yearlySalary; }
        public void setyearlySalary(double ySalary)
        { this.yearlySalary = ySalary; }

        
        //public double yearlySalary
        //{   getyearlySalary();
        //    return this.monthlySalary * 12 + this.yearlySalary;
        //}


        public override string ToString()
        {
            return "EMPLOYEE: " + name + ", " + number + " " + dateOfHire + " Their Monthly Salary is: $" + monthlySalary + " Their Yearly Salary is: $" + yearlySalary;
        }


    }
}
