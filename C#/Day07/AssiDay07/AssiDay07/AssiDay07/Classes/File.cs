using AssiDay07.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay07.Classes
{
    public class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading from file...");
        }

        public void Write()
        {
            Console.WriteLine("Writing to file...");
        }
    }
}
