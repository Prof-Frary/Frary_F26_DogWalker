using System;
using System.Collections.Generic;
using System.Text;

namespace Frary_F26_DogWalker
{
    internal class DogWalker
    {       
        public const string DOG_WALK_TYPE = "Dog Walk";
        public const string DOG_PARK_TYPE = "Dog Park";
        public const string PET_SITTING_TYPE = "Pet Sitting";
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
        public decimal WalkServiceCost { get; set; }  = 20.0m;
        public decimal ParkServiceCost { get; set; } = 25.0m;
        public decimal SittingServiceCost { get; set; } = 30.0m;
        public string ServiceType { get; set; }

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

        private decimal sCost;  //backing variable for the service cost
        private decimal wCost; //backing variable for the weekly cost        

        //constructors
        public DogWalker()
        {
            PetName = "";
            NumberPerWeek = 0;
            // calculating weekly cost in this case is not done
            // since it would not be valid

        }

        public DogWalker(string petName, uint numberPerWeek)
        {
            PetName = petName;
            NumberPerWeek = numberPerWeek;
            sCost = 20.0m; // default value for service cost
            CalculateWeeklyCost();
        }

        public DogWalker(string petName, uint numberPerWeek, string serviceType)
        {
            PetName = petName;
            NumberPerWeek = numberPerWeek;
            ServiceType = serviceType;
            // Set the service cost based on the service type
            
            CalculateWeeklyCost();
        }


        public decimal CalculateWeeklyCost()
        {
            switch (ServiceType)
            {
                case DOG_WALK_TYPE:
                    sCost = WalkServiceCost;
                    break;
                case DOG_PARK_TYPE:
                    sCost = ParkServiceCost;
                    break;
                case PET_SITTING_TYPE:
                    sCost = SittingServiceCost;
                    break;
                default:
                    sCost = 0.0m;
                    break;
            }
            wCost = NumberPerWeek * ServiceCost;
            return wCost;
        }

       

        
        public override string ToString()
        {
            return "Pet name is " + PetName +
                "\nService type is " + ServiceType +
                "\nNumber of walks/services per week is " +
                NumberPerWeek.ToString("N0") + 
                "\nCost per service is " +
                ServiceCost.ToString("C") +
                "\nTotal weekly cost is " + WeeklyCost.ToString("C");
        }

        
    }
}
