using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d2.Task4
{
    public static class Task4
    {
        public static (T Min, T Max) FindMinMax<T>(List<T> values) where T : IComparable<T>
        {
            if (values == null || values.Count == 0)
            {
                throw new ArgumentException("Пусто");
            }

            T min = values[0];
            T max = values[0];

            foreach (T value in values)
            {
                if (value.CompareTo(min) < 0) min = value;
                if (value.CompareTo(max) > 0) max = value;
            }

            return (min, max);
        }
    }
}
