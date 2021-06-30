using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public bool IsEconomical { get; set; }
        public string EnclosedTrunk { get; set; }
        public int Wheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public bool ChangedGears { get; set; }

        public void Drive()
        {
            if (ChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in drive");
          
            }
            else
            {
                Console.WriteLine($"{GetType().Name} is in park mode");
            }
        }
        public void Reverse()
        {
            if (ChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now reversing!");
                
            }
            else
            {
                Console.WriteLine("In park mode until gear is shifted");
            }

        }
        public void Park()
        {
            if (ChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is in park mode");
            }
            else
            {
                Console.WriteLine("Unable to park until gear is shifted!");
            }

           

        }
        public void HasChangedGears(bool isChanged)
        {
            ChangedGears = isChanged;
        }

    }
}

