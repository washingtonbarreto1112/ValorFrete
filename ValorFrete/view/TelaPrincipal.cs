using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValorFrete.view
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            decimal valor = 0;
            decimal frete = 0;

            valor = Convert.ToDecimal(tbxValor.Text);

            switch (cboUF.Text.ToUpper())
            {
                case "AM":
                    frete = 0.6m; 
                    break;
                case "MG":
                    frete = 0.35m;
                    break;
                case "RJ":
                    frete = 0.30m;
                    break;
                case "SP":
                    frete = 0.20m;
                    break;
                default:
                    frete = 0.70m;
                    break;
            }
            tbxFrete.Text = frete.ToString();
            lblValorFrete.Text =  (valor * (1 + frete)).ToString();
        }

        private void LimparTela()
        {
            tbxCliente.Text = string.Empty;
            tbxValor.Text = string.Empty;
            cboUF.SelectedIndex = -1;
            tbxFrete.Text = string.Empty;
            lblValorFrete.Text = string.Empty;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            decimal valor = 0;
            decimal frete = 0;

            valor = Convert.ToDecimal(tbxValor.Text);

            switch (cboUF.Text.ToUpper())
            {
                case "AM":
                    frete = 0.6m;
                    break;
                case "MG":
                    frete = 0.35m;
                    break;
                case "RJ":
                    frete = 0.30m;
                    break;
                case "SP":
                    frete = 0.20m;
                    break;
                default:
                    frete = 0.70m;
                    break;
            }
            tbxFrete.Text = frete.ToString();
            lblValorFrete.Text = (valor * (1 + frete)).ToString();
        }
    }
    }

