using System;
using System.Collections.Generic;
using System.Text;

namespace Frary_F26_DogWalker
{
    internal class DogWalker
    {

        private decimal sCost = 20.0m;  //backing variable for the service cost
        private decimal wCost; //backing variable for the weekly cost

        //constructors
        public DogWalker()
        {
            // PetName = "";
            //NumberPerWeek = 0;
            // calculating weekly cost in this case is not done
            // since it would not be valid

        }

        public DogWalker(string petName, uint numberPerWeek)
        {
            PetName = petName;
            NumberPerWeek = numberPerWeek;
            CalculateWeeklyCost();
        }

        public DogWalker(string petName, uint numberPerWeek, decimal serviceCost)
        {
            PetName = petName;
            NumberPerWeek = numberPerWeek;
            ServiceCost = serviceCost;
            CalculateWeeklyCost();
        }

        public decimal CalculateWeeklyCost()
        {
            wCost = NumberPerWeek * ServiceCost;
            return wCost;
        }

        //properties
        //automatic property
        public string PetName { get; set; }

        // an example of using a backing variable
        // and a protection of data
        public decimal ServiceCost
        {
            get { return sCost; }
            set
            {
                if (value > 0)
                {
                    sCost = value;
                }
            }
        }

        public uint NumberPerWeek { get; set; }

        // weekly cost can only be set within the class
        public decimal WeeklyCost
        {
            get { return wCost; }
            private set
            {
                if (value > 0)
                {
                    wCost = value;
                }
            }
        }

        
        public override string ToString()
        {
            return "Pet name is " + PetName + "\nNumber of walks/services per week is " +
                NumberPerWeek.ToString("N0") + 
                "\nCost per service is " +
                ServiceCost.ToString("C") +
                "\nTotal weekly cost is " + WeeklyCost.ToString("C");
        }

        
    }
}
