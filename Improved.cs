using System;
using System.Collections.Generic;
using System.Linq;

namespace Interviews.Improve
{
    class Improved
    {
        public double Sum(IEnumerable<double> values)
        {
            return values.Sum();
        }

        public double Sum(IEnumerable<string> values)
        {
            double sum = 0;
            foreach (var value in values)
            {
                if (double.TryParse(value, out double a))
                    sum += a;
            }
            return sum;
        }
    }
}
