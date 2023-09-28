using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ElsufevMP.Sprint1.Task7.V18.Lib
{
    public class DataService : ISprint1Task7V18
    {
        public double Calculate(double x, double y)
        {
            double res = (1 + Math.Pow(Math.Sin(x + y), 2)) / (2 + Math.Abs(x - ((2 * x) / (1 + Math.Sqrt(x) + Math.Sqrt(y))))) + x;
            return res;
        }
    }
}
