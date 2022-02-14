using MyTaskCars.Enums;
using MyTaskCars.Models;
using System.Collections.Generic;

namespace MyTaskCars.ViewModels
{
    public class CarsViewModel
    {
        public List<Avtomobil> List { get; set; }
        public Rang rang { get; set; }
    }
}
