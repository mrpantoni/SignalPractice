using System;
using System.Collections.Generic;
using System.Text;

namespace GyakorloFeladatok2
{
    public class BuborekosRendezes
    {
        public int[] Buborekos(int[] integersList)
        {
            int temp = integersList[0];

            for (int i = 0; i < integersList.Length; i++)
            {
                for (int j = i + 1; j < integersList.Length; j++)
                {
                    if (integersList[i] > integersList[j])
                    {
                        temp = integersList[i];

                        integersList[i] = integersList[j];

                        integersList[j] = temp;
                    }
                }
            }
            return integersList;
        }
    }
}
