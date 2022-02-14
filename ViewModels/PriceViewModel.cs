using MyTaskCars.Enums;
using MyTaskCars.Models;
using System.Collections.Generic;

namespace MyTaskCars.ViewModels
{
    public class PriceViewModel
    {
        public List<Avtomobil> list { get; set; }
        public int startPrice { get; set; }
        public int endPrice { get; set; }

    }
}
