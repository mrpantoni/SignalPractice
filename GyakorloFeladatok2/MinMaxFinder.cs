using System;
using System.Collections.Generic;

namespace GyakorloFeladatok2
{
    public class MinMaxFinder
    {
        public int FindMin(List<int> integersList)
        {
            int max = integersList[0];
            if (integersList == null)
            {
                throw new ArgumentException("List is empty");
            }
            else
            {
                foreach (int num in integersList)
                {
                    if (num < max)
                    {
                        max = num;
                    }
                }
                return max;
            }
        }
        public int FindMax(List<int> integersList)
        {
            int min = integersList[0];
            if (integersList == null)
            {
                throw new ArgumentException("List is empty");
            }
            else
            {
                foreach (int num in integersList)
                {
                    if (num > min)
                    {
                        min = num;
                    }
                }
                return min;
            }
        }

    }
}
