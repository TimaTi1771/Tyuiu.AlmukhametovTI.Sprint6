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
            
            int l = (stopValue - startValue) + 1;
            double[] valueArray = new double[l];         
            double y;
            double o;                        
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {                                            
                    o = 2 - x;                                     
                    if (x == 2)
                    {
                        o = 0;
                        y = 0;
                        
                    }
                    else
                    {
                        y = Math.Sin(x) + ((Math.Cos(x) + 1) / 2 - x) + 2 * x;                       
                        valueArray[count] = Math.Round(y, 2);
                        count++;
                    }
                
            }
            return valueArray;
        }
    }
}
   


