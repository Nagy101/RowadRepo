using AssiDay07.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes
{
    public class Car : IMovable
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        #region Ctors
        public Car()
        {
            Id = 0;
            Brand = "Unknown";
            Price = 0.0;
        }
        public Car(int _Id)
        {
            Id = _Id;
        }
        public Car(int _Id, string _Brand)
        {
            Id = _Id;
            Brand = _Brand;
        }
        public Car(int _Id, string _Brand, double _Price)
        {
            Id = _Id;
            Brand = _Brand;
            Price = _Price;
        } 
        #endregion
        override public string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Price: {Price}";
        }
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
}
