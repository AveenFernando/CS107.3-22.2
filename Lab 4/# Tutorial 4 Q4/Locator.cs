using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Tutorial_4_Q4
{
    internal class Locator
    {
        public double FindArea(double r)
        {
            return Math.PI * r * r;
        }
        public double FindCircumference(double r)
        {
            return 2 * Math.PI * r;
        }
    }
}
