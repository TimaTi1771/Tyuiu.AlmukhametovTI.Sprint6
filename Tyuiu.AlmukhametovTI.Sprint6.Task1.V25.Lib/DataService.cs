using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AlmukhametovTI.Sprint6.Task1.V25.Lib
{
    public class DataService : ISprint6Task1V25
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

                F = Math.Round(((5 * (double)x + 2.5) / (Math.Sin((double)x) - 2) + 2), 2); 
                valueArray[count] = F;
                count++;

            }
            return valueArray;
        }
    }
}
