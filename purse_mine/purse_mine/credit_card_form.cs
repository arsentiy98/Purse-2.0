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
    public partial class credit_card_form : Form
    {
        CreditCard creditcard = new CreditCard();
        Money money = new Money();
        public credit_card_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = Int32.Parse(textBox1.Text);
            money.SetCash(sum);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Int32.Parse(textBox1.Text);
            textBox3.Text = textBox1.Text;
            textBox2.Text = creditcard.CalculateTheCredit(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
