using System;
using System.Collections.Generic;
using System.Text;

namespace Frary_F26_DogWalker
{
    internal class DogWalker
    {
        
        private decimal sCost =20.0m;  //backing variable for the service cost
     /* This is 
        public decimal getServiceCost()
        {
            return sCost;
        }
        public void setServiceCost(decimal value)
        {
            if (value > 0)
            {
                sCost = value;
            }
        }
     */

        //constructors
        public DogWalker()
        {
            PetName = "";
            NumberPerWeek = 1;
        }

        public DogWalker(string petName, uint numberPerWeek)
        {
            PetName = petName;
            NumberPerWeek = numberPerWeek;
           
            
        }

      public decimal CalculateWeeklyCost()
        {
            return NumberPerWeek * ServiceCost;
        }

        //properties
        //automatic property
        public string PetName { get; set; }

        // an example of using a backing variable
        // and a protection of data
        public decimal ServiceCost
        {
            get { return sCost; }
            set {
                if (value > 0)
                {
                    sCost = value;
                }
            }
        }

        public uint NumberPerWeek{ get; set; }
    }
}
