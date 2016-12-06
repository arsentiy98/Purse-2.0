using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purse
{
    /**
    \brief GoldenCard class.
    \author Bogdan Lotysh
    \version 1.0
*/
    public class GoldenCard
    {
        IMoney money1 = new Money();
        double percent = 0.07;
        string valuta = "UAH";

        /*!
            \return double

            Shows users's balance.
        */
        public double GetBalance()
        {
            return money1.GetCash();
        }

        /*!
            \param double

            \return void

            User enter value of money, wich after will be filled.
        */
        public void Fill(double cash)
        {
            if(valuta == "UAH")
            {
                money1.SetCash(money1.GetCash() + cash);
            }
            else
            {
                ConvertToUAH();
                money1.SetCash(money1.GetCash() + cash);
            }
            MessageBox.Show("Your balance filled.");
        }
        /*!
            \param double

            \return double

             User enter value of money, wich after will be filled.
*/
        public double Withdraw(double cash)
        {
            if ((money1.GetCash() - cash) < 0)
            {
                MessageBox.Show("Your balance is too small to make a withdraw.");
                return 0;
            }
            else
            {
                if (valuta == "USD")
                {
                    money1.SetCash(money1.GetCash() - cash);
                    //money1.SetCash(money1.GetCash() + cash * percent);
                    MessageBox.Show("Succsess.");
                    return (cash + cash * percent) * 27;
                }
                else
                {
                    money1.SetCash(money1.GetCash() - cash);
                    //money1.SetCash(money1.GetCash() + cash * percent);
                    MessageBox.Show("Succsess.");
                    return (cash + cash * percent);
                }
            }
        }
        /*!

    \return void

     Converting user's money into USD.
*/
        public void ConvertToUSD()
        {
            if (valuta != "USD")
            {
                money1.SetCash(money1.GetCash() / 27);
                valuta = "USD";
            }
            else
            {
                MessageBox.Show("You've already that currency!");
            }
        }
        /*!

\return void

Converting user's money into UAH.
*/
        public void ConvertToUAH()
        {
            if (valuta != "UAH")
            {
                money1.SetCash(money1.GetCash() * 27);
                valuta = "UAH";
            }
            else
            {
                MessageBox.Show("You've already that currency!");
            }
        }
    }
}
