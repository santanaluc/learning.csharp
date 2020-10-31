using System;
using System.Collections.Generic;
using System.Text;

namespace Restricoes
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable // Vai ter que ser de um tipo "T" qualquer desde que seja comparavel
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("Empty");
            }


            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;
        }
    }
}
