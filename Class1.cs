using System;
using System.Collections.Generic;

namespace Interviews.Improve
{
    public class Class1
    {
        public double Sum(List<double> values)
        {
            double sum = 0;
            for(var i = 0; i < values.Count; i++)
            {
                sum += values[i];
            }
            return sum;
        }

        public double Sum(List<string> values)
        {
            double sum = 0;
            for (var i = 0; i < values.Count; i++)
            {
                sum += Convert.ToDouble(values[i]);
            }
            return sum;
        }
    }
}
