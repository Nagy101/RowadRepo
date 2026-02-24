using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay10.Classes
{
    class SortingAlgorithm<T> where T : ICloneable
    {
        public void Sort(T[] items, Comparison<T> comparison)
        {
            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = 0; j < items.Length - i - 1; j++)
                {
                    if (comparison(items[j], items[j + 1]) > 0)
                    {
                        Swap(ref items[j], ref items[j + 1]);
                    }
                }
            }
        }
        public void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
