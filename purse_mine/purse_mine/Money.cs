using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purse_mine
{
    public class Money
    {        
        double cash;

        public void SetCash(double a)
        {
            cash += a;
        }
        public double GetCash()
        {
            return cash;
        }
        public double Pay(double a)
        {           
            if (cash <a)
            {
                return 0;
            }
            else
            {
              return  cash = cash - a;                  
            }
        }
    }
}
