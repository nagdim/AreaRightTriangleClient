using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLogic
{
    public static class AreaTriangleTools
    {
        public static double SquareRightTriangle(double a, double b, double c)
        {
            double[] sideArray = { a, b, c };

            for (int i = 0; i < sideArray.Length; i++)
            {
                if (sideArray[i] <= 0)
                {
                    var parameterName = MethodBase.GetCurrentMethod().GetParameters()[i].Name;
                    throw new ArgumentException(string.Format("{0} can not be less than zero ", parameterName));
                }
            }

            Array.Sort(sideArray);

            bool isRectangular = Math.Abs(Math.Pow(sideArray[0], 2) + Math.Pow(sideArray[1], 2) - Math.Pow(sideArray[2], 2)) <= 0;

            if (isRectangular)
            {
                return 0.5 * sideArray[0] * sideArray[1];
            }

            throw new AggregateException("Triange is not rectangular");
        }
    }
}
