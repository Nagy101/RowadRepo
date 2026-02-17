using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Product : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(int _Id ,string _Name ,decimal _Price)
        {
            Id = _Id;
            Name = _Name;
            Price = _Price;
        }
        public int CompareTo(object obj)
        {
            Product product = (Product)obj;
            if ( this.Price > product.Price)
                return 1;
            else if ( this.Price < product.Price)
                return -1;
            else
                return 0;
        }
        override public string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Price: {Price}";
        }
    }
}
