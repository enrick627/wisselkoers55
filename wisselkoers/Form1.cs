/*Wisselkoers - Omrekenen van EUR naar USD.
*Maak een consoletoepassing waarbij een bedrag in euro omgerekend wordt naar dollar.De
*wisselkoers van € 1,00 = $ 1,0975. Het resultaat moet er als volgt uitzien: X EUR is gelijk aan Y
*USD.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wisselkoers
{
    public partial class wisselkoers_form : Form
    {
        public wisselkoers_form()
        {
            InitializeComponent();
        }

        private void button_eurnaardollar_Click(object sender, EventArgs e)
        {

            double EUR = double.Parse(invoer_euro.Text), Dollar = 1.0975, somNaarDollar;
            somNaarDollar = EUR * Dollar;
            this.textbox_dollar.Text = somNaarDollar.ToString();


        }

        private void invoer_euro_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_dollar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_dollarnaarEUR_Click(object sender, EventArgs e)
        {
            
                double Dollar = double.Parse(textbox_dollar.Text), EUR = 0.91, somEur;
                somEur = Dollar * EUR;
                this.invoer_euro.Text = somEur.ToString();
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
