using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chpt5_Ex6
{
    class areaOfRectangle
    {
        public static double rArea;
        public static double rLength;
        public static double rWidth;

        //this is a constructor 3 fields
        public areaOfRectangle(double irArea, double irLength, double irWidth)
        {   
            rArea = irArea;
            rLength=irLength;
            rWidth=irWidth;
        }

        //this is a constructor 2 fields
        public areaOfRectangle(double irArea, double irLength)
        {
            rArea = irArea;
            rLength = irLength;
        }

        //this is a constructor 1 field
        public areaOfRectangle(double irArea)
        {rArea = irArea; }

        //no field constructor
        public areaOfRectangle()
        {                      }

        public double rectangleLengthInput
        {
            get { return rLength; }
            set { rLength = value; }
        }

        public double rectangleWidthInput
        {
            get { return rWidth; }
            set { rWidth = value; }
        }

        public override string ToString()
        {
            double rArea;
            rArea = rLength * rWidth;
            return "Area Of The Rectangle= " + rArea;
        }
        
          
    }
}
