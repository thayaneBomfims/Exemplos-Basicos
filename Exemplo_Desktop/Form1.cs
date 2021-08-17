using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo_Desktop
{
    public partial class Calculadora : Form
    {

        string operador = "";
        decimal insercao = 0;
        decimal result = 0;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNum(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtValor.Text = txtValor.Text + bt.Text;
        }

        private void btnVirg(object sender, EventArgs e)
        {
            txtValor.Text += ".";
        }

        private void btnClean(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            operador = "";
            insercao = 0;
            result = 0;
        }

        private void btnSingle(object sender, EventArgs e)
        {
            txtValor.Text = "";
        }

        private void Som(object sender, EventArgs e)
        {
            insercao = insercao + decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
            txtValor.Text = "";

            label1.Text = Convert.ToString(insercao) + " +";            
            operador = "+";
        }

        private void Sub(object sender, EventArgs e)
        {
            insercao = (decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture));

            if(result == 0)
            {
                result = insercao;
            }
            else
            {
                insercao = result - insercao;
            }
            
            txtValor.Text = "";

            label1.Text = Convert.ToString(insercao) + " -";
            operador = "-";            
        }

        private void Div(object sender, EventArgs e)
        {
            insercao = (decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture));

            if (result == 0)
            {
                result = insercao;
            }
            else
            {
                insercao = result / insercao;
            }

            txtValor.Text = "";

            label1.Text = Convert.ToString(insercao) + " /";
            operador = "/";
        }

        private void Mult(object sender, EventArgs e)
        {
            insercao = (decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture));

            if (result == 0)
            {
                result = insercao;
            }
            else
            {
                insercao = result * insercao;
            }

            txtValor.Text = "";

            label1.Text = Convert.ToString(insercao) + " x";
            operador = "*";
        }

        private void btnRes(object sender, EventArgs e)
        {

            switch (operador)
            {
                case "+":
                    result = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
                    txtValor.Text = Convert.ToString(insercao + result);
                    label1.Text = "";
                    break;

                case "-":
                    result = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
                    txtValor.Text = Convert.ToString(insercao - result);
                    label1.Text = "";
                    insercao = 0;
                    result = 0;
                    break;

                case "/":
                    result = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
                    txtValor.Text = Convert.ToString(insercao / result);
                    label1.Text = "";
                    break;

                case "*":
                    result = decimal.Parse(txtValor.Text, CultureInfo.InvariantCulture);
                    txtValor.Text = Convert.ToString(insercao * result);
                    label1.Text = "";
                    break;
            }

        }
    }
}
