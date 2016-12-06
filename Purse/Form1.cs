using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purse
{
    public partial class Form1 : Form
    {
        Purse purse = new Purse();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Cash : " + purse.cash.GetCash().ToString() + "  UAH";
            //label_cash.Text = purse.cash.GetCash().ToString();
        }

        private void button_Fill_Click(object sender, EventArgs e)
        {
            try
            {
                if (purse.cash.GetCash() < Convert.ToDouble(textBox_fill.Text))
                {
                    MessageBox.Show("Not enough money");
                }
                else
                {
                    purse.cash.SetCash(purse.cash.GetCash() - Convert.ToDouble(textBox_fill.Text));
                    purse.goldCard.Fill(Convert.ToDouble(textBox_fill.Text));
                    label_goldBalance.Text = purse.goldCard.GetBalance().ToString();
                    this.Text = "Cash : " + purse.cash.GetCash().ToString() + "  UAH";
                    //label_cash.Text = purse.cash.GetCash().ToString();
                }
            }
            catch
            {
                MessageBox.Show("Type digit amount");
            }
        }

        private void button_Withdraw_Click(object sender, EventArgs e)
        {
            try
            {
                double res = purse.goldCard.Withdraw(Convert.ToDouble(textBox_withdraw.Text));
                purse.cash.SetCash(purse.cash.GetCash() + res);
                label_goldBalance.Text = purse.goldCard.GetBalance().ToString();
                this.Text = "Cash : " + purse.cash.GetCash().ToString() + "  UAH";
                //label_cash.Text = purse.cash.GetCash().ToString();
            }
            catch
            {
                MessageBox.Show("Type digit amount");
            }
        }

        private void button_ConvertUsd_Click(object sender, EventArgs e)
        {
            purse.goldCard.ConvertToUSD();
            label_goldBalance.Text = purse.goldCard.GetBalance().ToString();
            label_valuta.Text = "USD";
        }

        private void button_ConvertUah_Click(object sender, EventArgs e)
        {
            purse.goldCard.ConvertToUAH();
            label_goldBalance.Text = purse.goldCard.GetBalance().ToString();
            label_valuta.Text = "UAH";
        }
    }
}
