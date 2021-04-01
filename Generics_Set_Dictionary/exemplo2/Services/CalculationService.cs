using System;
using System.Collections.Generic;

namespace exemplo2.Services
{
    public class CalculationService
    {
        public  T Max<T>(List<T> list) where T : IComparable
        {
            if(list.Count == 0)
            {
                throw new InvalidOperationException("A lista não pode ser vazia!");
            }

            T max = list[0];
            foreach(T obj in list)
            {
                if(obj.CompareTo(max) > 0)
                {
                    max = obj;
                }
            }
            return max;
        }
    }
}