﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public interface IVehicle
    {
        public int Wheels { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Seats { get; set; }
        public void Drive();
        public void Reverse();
        public void Park();
        public void HasChangedGears(bool v);


    }
}
