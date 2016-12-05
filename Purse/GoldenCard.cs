using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purse
{
    class GoldenCard
    {
        IMoney money1;
        double percent = 0;
        string valuta = "UAH";

        public void GetBalance()
        {
            MessageBox.Show("Your balance: " + money1.GetCash() + ".");
        }
        public void Fill(int cash)
        {
            money1.SetCash(cash);
            MessageBox.Show("Your balance filled.");
        }
        public void Withdraw(int cash, int per)
        {
            if ((money1.GetCash() - cash) < 0)
            {
                MessageBox.Show("Your balance is too small to make a withdraw.");
            }
            else
            {
                money1.SetCash(money1.GetCash() - cash);
                money1.SetCash(money1.GetCash() + cash * per);
                MessageBox.Show("Succsess.");
            }
        }
        public void AddGoldBonus7()
        {
            percent = 0.7;
            MessageBox.Show("Your bonus is 7% from withdraw.");
        }
        public void CancelGoldBonus7()
        {
            percent = 0;
            MessageBox.Show("Succsess.");
        }

        public void ConvertToUSD()
        {
            if (valuta != "USD")
            {
                money1.SetCash(money1.GetCash() / 27);
                valuta = "USD";
                MessageBox.Show("Converted to " + valuta + ".");
            }
            else
            {
                MessageBox.Show("You've already that currency!");
            }
        }
        public void ConvertToUAH()
        {
            if (valuta != "UAH")
            {
                money1.SetCash(money1.GetCash() * 27);
                valuta = "UAH";
                MessageBox.Show("Converted to " + valuta + ".");
            }
            else
            {
                MessageBox.Show("You've already that currency!");
            }
        }
    }
}
