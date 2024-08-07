using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d2.Task1
{
    public class Task1
    {
        public void Swap<T>(ref T first, ref T second )
        {
            T rez=first;
            first = second;
            second = rez;
            Console.WriteLine($"{first} {second}");
        }
    }
}
