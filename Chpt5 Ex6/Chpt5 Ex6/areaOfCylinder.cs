using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt5_Ex6
{
    class areaOfCylinder
    { 
        public static double cylRadius;        
        public static double cylHeight;

        //this is a constructor 2 fields
        public areaOfCylinder(double icylRadius, double icylHeight)
        {  
            cylRadius=icylRadius;
            cylHeight=icylHeight;
        }

        //this is a constructor 1 fields
        public areaOfCylinder(double icylRadius)
        {
             cylRadius = icylRadius;
        }

        public areaOfCylinder()
        {                     }



        public double cylinderRadiusInput
        {
            get { return cylRadius; }
            set { cylRadius = value; }
        }

        public double cylinderHeightInput
        {
            get { return cylHeight; }
            set { cylHeight = value; }
        }
       
        
        

        public override string ToString()
        {
            double cylArea = 3.14 * (cylRadius * cylRadius) * cylHeight;
            return "Area Of Cylinder= " + cylArea;
        }  



       
            
            
       
    }
}
