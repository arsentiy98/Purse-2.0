using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purse_mine{
    
    public class CreditCard
    {
        Money money;
        int Number;
        void SetNumber(int num) { Number = num; }
        int GetNumber() { return Number; }

        public void Pay(int amount)
        {
            double current = money.GetCash();
            if (current < amount)
            {
                MessageBox.Show("Not enough money.");
            }
            else
            {
                money.SetCash(current - amount);
            }
        }
        public string CalculateTheCredit(string requiredSum) {
            double integer = Int32.Parse(requiredSum);
            integer += (integer * 4)/100;
            string integer2 = integer.ToString();
            return integer2;
        }

    }
}
