using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purse{
    
    public class CreditCard
    {
        IMoney money;
        //int Number;
        double Credit;

        //void SetNumber(int num) { Number = num; }
        //int GetNumber() { return Number; }

        public void SetCredit(double num) { Credit = num; }
        public double GetCredit() { return Credit; }

        public double GetBalance()
        {
            return money.GetCash();
        }

        public double Withdraw(double cash)
        {
            /*if ((money.GetCash() - cash) < 0)
            {
                MessageBox.Show("Your balance is too small to make a withdraw.");
                return 0;
            }
            else*/
            {
                money.SetCash(money.GetCash() - cash);
                MessageBox.Show("Succsess.");
                return (cash);
            }
        }

        
        public void PayCredit(IMoney m)
        {
            m.SetCash(m.GetCash() - GetCredit());
            SetCredit(0);
        }
        

        public void CalculateTheCredit(string requiredSum)
        {
            double integer = Int32.Parse(requiredSum);
            integer += (integer * 4)/100;
            SetCredit(integer);
        }

    }
}
