using MyTaskCars.Enums;
using System;

namespace MyTaskCars.Models
{
    public class Avtomobil
    {
        public int Id { get; set; }
        public Firma Owner { get; set; }
        public Rusum Model { get; set; }
        public Rang Color { get; set;} 
        public int Price { get; set; }

        public Avtomobil(int _id, Firma _owner, Rusum _model, Rang _color, int _price)
        {
            this.Id = _id;
            this.Owner = _owner;
            this.Model = _model;    
            this.Color = _color;
            this.Price = _price;
        }

        public Avtomobil()
        {

        }

    }
}
