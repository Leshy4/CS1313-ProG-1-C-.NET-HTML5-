using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_4_Ex_1
{
    class Invoice
    {

        public int itemNumber;
        public string Price;        
        public string Description;
        


       

         //this is a constructor 3 fields
        public Invoice(int aitemNumber,  string aDescription, string aPrice)
        {
            itemNumber = aitemNumber;
            Price = aPrice;
            Description = aDescription;
        }

        //this is a constructor with two fields
        public Invoice(int aitemNumber, string aDescription)
        {   itemNumber = aitemNumber;
            Description = aDescription;    
        }
                

        //this is a constructor with 1 field
        public Invoice(int aitemNumber)
        {itemNumber = aitemNumber;}

        //this is a constructor with no fields
        public Invoice()
        {        }

        private int getitemNumber()
        { return this.itemNumber; }
        private void setitemNumber(int n)
        { this.itemNumber = n; }


        private string getPrice()
        { return this.Price; }
        private void setPrice(string p)
        { this.Price = p; }

       





        public override string ToString()
        {
            return "ITEM: " + itemNumber + ", " + Description + " " + Price;
        }      


    }
 
}
