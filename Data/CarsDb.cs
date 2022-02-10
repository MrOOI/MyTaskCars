using MyTaskCars.Enums;
using MyTaskCars.Models;
using System.Collections.Generic;

namespace MyTaskCars.Data
{
    public class CarsDb
    {
        public List<Avtomobil> Avtomobils { get; set;} 

        //Mashinalarni to'ldirish, dynamic holda
        //Databasedan EF bilan chaqirib 
        public static List<Avtomobil> autos()
        {
            List <Avtomobil> Mashinalar = new List<Avtomobil>();

            Mashinalar.Add(new Avtomobil(0, Firma.Chevrolet, Rusum.Lacetti, Rang.black, 11500));
            Mashinalar.Add(new Avtomobil(1, Firma.Daewoo, Rusum.Damas, Rang.white, 7500));
            Mashinalar.Add(new Avtomobil(2, Firma.Chevrolet, Rusum.Matiz, Rang.white, 5000));
            Mashinalar.Add(new Avtomobil(3, Firma.Ravon, Rusum.Nexia3, Rang.blue, 12000));
            Mashinalar.Add(new Avtomobil(4, Firma.Chevrolet, Rusum.Nexia2, Rang.black, 6500));
            Mashinalar.Add(new Avtomobil(5, Firma.Chevrolet, Rusum.Cobalt, Rang.magenta, 11500));
            Mashinalar.Add(new Avtomobil(6, Firma.Chevrolet, Rusum.Lacetti, Rang.black, 11500));
            Mashinalar.Add(new Avtomobil(7, Firma.Daewoo, Rusum.Damas, Rang.white, 7500));
            Mashinalar.Add(new Avtomobil(8, Firma.Chevrolet, Rusum.Malibu, Rang.white, 25000));
            Mashinalar.Add(new Avtomobil(9, Firma.Ravon, Rusum.Nexia3, Rang.blue, 12000));

            return Mashinalar;
        }
    }
}
