using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Ex_1w
{
    class Employees
    {

        public string name;
        public string dateOfHire;
        public double monthlySalary;
        public double yearlySalary;
        public string number;
        private string v1;
        private string v2;
        private int v3;
        private string v4;




        //this is a constructor 5 fields
        public Employees(string iName, string idateOfHire, double imonthlySalary,double iyearlySalary , string iNumber)
        {
            name = iName;
            dateOfHire = idateOfHire;
            monthlySalary = imonthlySalary;
            number = iNumber;
            yearlySalary = iyearlySalary;

        }

        //this is a constructor 4 fields
        public Employees(string idateOfHire, double imonthlySalary, string iNumber, double iyearlySalary)
        {

            dateOfHire = idateOfHire;
            monthlySalary = imonthlySalary;
            number = iNumber;
            yearlySalary = iyearlySalary;

        }

        //this is a constructor 3 fields
        public Employees(double imonthlySalary, string iNumber, double iyearlySalary)
        {

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

        public Employees(string v1, string v2, int v3, string v4, double yearlySalary)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.yearlySalary = yearlySalary;
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



        public override string ToString()
        {
            return "EMPLOYEE: " + name + ", " + number + " " + dateOfHire + " Their Monthly Salary is: $" + monthlySalary + " Their Yearly Salary is: $" + yearlySalary;
        }


    }
}
