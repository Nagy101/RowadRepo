using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Interface
{
    public interface IShape
    {
        public double Area { get; }
        public void Draw();
        void PrintDetails()
        {
            Console.WriteLine($"Area = {Area}");
        }
    }
}
