using Microsoft.AspNetCore.Hosting;
using MyTaskCars.Data;
using MyTaskCars.Enums;
using MyTaskCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTaskCars.Services
{
    public class CarService : ICarService
    {
        List<Avtomobil> Mashinalar;

        private readonly IWebHostEnvironment _webHostEnvironment;
        public CarService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public List<Avtomobil> GetAllCars()
        {
            Mashinalar = new List<Avtomobil>();
            Mashinalar = CarsDb.autos();

            return Mashinalar;
        }

        public List<Avtomobil> GetByColor(Rang color)
        {
            Mashinalar = new List<Avtomobil>();
            Mashinalar = CarsDb.autos().Where(item => item.Color == color).ToList();
            return Mashinalar;
        }

        public List<Avtomobil> GetByPrice(int startPrice, int endPrice)
        {
            Mashinalar = new List<Avtomobil>();
            Mashinalar = CarsDb.autos().Where(item => item.Price > startPrice && item.Price < endPrice).ToList();
            return Mashinalar;
        }
    }
}
