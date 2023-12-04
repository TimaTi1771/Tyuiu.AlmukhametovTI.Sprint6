using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task2.V24.Lib
{
    public class DataService : ISprint6Task2V24
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double F;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x != 0)
                {
                    F = Math.Round((Math.Sin((double)x) + ((Math.Cos((double)x) + 1) / (2 - (double)x)) + (2 * ((double)x))), 2);
                    valueArray[count] = F;
                    count++;
                }
                else
                {
                    F = 0;
                    valueArray[count] = F;
                    count++;
                }

            }
            return valueArray;
        }
    }
}
