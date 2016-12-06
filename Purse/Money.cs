using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purse
{
    public class Money : IMoney
    {
        double cash;

        public void SetCash(double a)
        {
            cash = a;
        }
        public double GetCash()
        {
            return cash;
        }
    }
}
