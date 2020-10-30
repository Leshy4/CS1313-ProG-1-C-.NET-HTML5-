using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt5_Ex6
{
    class areaOfCircle
    {
        public static double cArea;
        public static double cRadius;

        //this is a constructor 2 fields
        public areaOfCircle(double icRadius, double icArea)
        {cArea = icArea;
         cRadius=icRadius;
         }

        //this is a constructor 1 field
        public areaOfCircle(double icRadius)
        {cRadius = icRadius;}

        //no field constructor
        public areaOfCircle()
        {                       }

        public double circleRadiusInput
        {
            get { return cRadius; }
            set { cRadius = value; }
        }

        public override string ToString()
        {
            double cArea;
            cArea = 3.14 * (cRadius * cRadius);
            return "Area Of The Circle= " + cArea;
        }

               
        
           
    }
}
