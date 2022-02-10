using MyTaskCars.Enums;
using MyTaskCars.Models;
using System;
using System.Collections.Generic;

namespace MyTaskCars.Services
{
    public interface ICarService
    {
        List<Avtomobil> GetAllCars(); //barcha mashinalar ro'yxatini olish
        List<Avtomobil> GetById(int id);//Id bo'yicha mashinalar ro'yxatini olish
        List<Avtomobil> GetByPrice(int startPrice, int endPrice);//Narxi boyicha mashinalar royxatini olish
        List<Avtomobil> GetByColor(Rang color); //Rangi boyicha mashinalar ro'yxatini olish
    }
}
