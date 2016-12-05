using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace purse_mine
{
    public partial class Form1 : Form
    {
        Money money = new Money();
        CreditCard creditcard = new CreditCard();
        credit_card_form credit = new credit_card_form();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string num = (money.GetCash()).ToString(); MessageBox.Show(num);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            int num = Int32.Parse(textBox1.Text); money.SetCash(num);
            MessageBox.Show("Fill completed");
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(textBox2.Text);
            double result = money.Pay(num);
            if (result == 0) { MessageBox.Show("Not enough money!!"); }
            else MessageBox.Show("Withdrawn completed!");
            textBox2.Clear();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            credit.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Close credit methods");
        }
    }
}
