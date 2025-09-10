using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace AppExemplo2.Formularios
{
    public partial class FormExemploComboBox : Form
    {
        public FormExemploComboBox()
        {
            InitializeComponent();
            txtPercDesconto.Visible = false;
            lbPecentual.Visible = false;
           
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;
            double valorCompra = Convert.ToDouble(txtValorCompra.Text);
            double valorComDesconto = 0;
            switch (tipoCliente)
            {
                case 0:
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.25;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }
                case 1:
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.20;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }
                case 2:
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.15;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }
                case 3:
                    {
                        valorComDesconto = valorCompra - valorCompra * 0.10;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }
                case 4:
                    {

                        double desconto = Convert.ToDouble(txtPercDesconto.Text) / 100;
                        valorComDesconto = valorCompra - valorCompra * desconto;
                        txtResultado.Text = valorComDesconto.ToString("C2");
                        break;
                    }
                default:
                    {
                        MessageBox.Show("SELECIONE UM CLIENTE!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            cbTipoCliente.SelectedIndex = -1;
            txtPercDesconto.Clear();
            txtResultado.Clear();
            txtValorCompra.Clear();
            txtPercDesconto.Visible = false;
            lbPecentual.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCliente = cbTipoCliente.SelectedIndex;

            if(tipoCliente == 4)
            {

                txtPercDesconto.Visible = true;
                lbPecentual.Visible = true;
            }
            else
            {
                txtPercDesconto.Visible = false;
                lbPecentual.Visible = false;
            }

        }

        private void cbTipoCliente_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void txtValorCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValorCompra_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;
    
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;

            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;
                if (e.KeyCode == Keys.Enter) verificarNumero = true; 
                if (e.KeyCode == Keys.Back) verificarNumero = true; 
                int qtdVirgula = txtValorCompra.Text.Count(v => v == ','); 
                if (qtdVirgula > 1) verificarNumero = false;
                                                            
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCompra.Text = txtValorCompra.Text.Remove(txtValorCompra.Text.Length - 1);
            }
        }

        private void txtPercDesconto_KeyUp(object sender, KeyEventArgs e)
        {

            bool verificarNumero = false;

            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;

            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;
                if (e.KeyCode == Keys.Enter) verificarNumero = true;
                if (e.KeyCode == Keys.Back) verificarNumero = true;
                int qtdVirgula = txtPercDesconto.Text.Count(v => v == ',');
                if (qtdVirgula > 1) verificarNumero = false;

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPercDesconto.Text = txtPercDesconto.Text.Remove(txtPercDesconto.Text.Length - 1);
            }

        }
    }
}
