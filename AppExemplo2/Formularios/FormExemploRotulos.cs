using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.Formularios
{
    public partial class FormExemploRotulos : Form
    {
        public FormExemploRotulos()
        {
            InitializeComponent();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtPercentual.Clear();
            txtSalarioAtual.Clear();
            txtSalarioAtual.Select();
            lbResultado.Text = "Salário reajustado: ";
            lbResultado.ForeColor = Color.Black;
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double salarioAtual = 0;
            double percentual = 0;
            double salarioReajustado = 0;

            salarioAtual = Convert.ToDouble(txtSalarioAtual.Text);
            percentual = Convert.ToDouble(txtPercentual.Text);
            percentual = percentual / 100;

            salarioReajustado = salarioAtual + salarioAtual * percentual;

            lbResultado.Text = $"O salário atualizado: {salarioReajustado.ToString("C2")}";
            lbResultado.ForeColor = Color.Blue;
        }

        private void txtSalarioAtual_Leave(object sender, EventArgs e)
        {
            if(txtSalarioAtual.Text == "")
            {
                MessageBox.Show("O campo está vazio!", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioAtual.Select();
                
            }
            else
            {
                txtPercentual.Select();
            }
        }

        private void txtSalarioAtual_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNumero = false;
            //Verificação do que foi digitado => Número ou Letra?
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNumero = true;

            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNumero = true;//liberar a vírgula
                if (e.KeyCode == Keys.Enter) verificarNumero = true; //liberar a tecla enter
                if (e.KeyCode == Keys.Back) verificarNumero = true; //liberar a tecla back
                int qtdVirgula = txtSalarioAtual.Text.Count(v => v == ','); //contar virgulas
                if (qtdVirgula > 1) verificarNumero = false;//verificar virgulas
                                                            //validação final => a mensagem vai aparecer se um dos itens não foi atendido
            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSalarioAtual.Text = txtSalarioAtual.Text.Remove(txtSalarioAtual.Text.Length - 1);
            }
        }

        private void txtSalarioAtual_Leave_1(object sender, EventArgs e)
        {
            if (txtSalarioAtual.Text == "")
            {
                MessageBox.Show("Não foi preenchido tudo!");

                txtSalarioAtual.Select();
            }
            
        }

        private void txtPercentual_Leave(object sender, EventArgs e)
        {
            if (txtPercentual.Text == "")
            {
                MessageBox.Show("Não foi preenchido tudo!");

                txtPercentual.Select();
            }
                
        }

        private void txtPercentual_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPercentual_KeyUp(object sender, KeyEventArgs e)
        {
            bool verificarNum = false;
           
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9) || (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                verificarNum = true;

            }
            else
            {
                if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Decimal) verificarNum = true;
                if (e.KeyCode == Keys.Enter) verificarNum = true; 
                if (e.KeyCode == Keys.Back) verificarNum = true; 
                int qtdVirgula = txtPercentual.Text.Count(v => v == ','); 
                if (qtdVirgula > 1) verificarNum = false;
                                                         
            }

            if (verificarNum == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPercentual.Text = txtPercentual.Text.Remove(txtPercentual.Text.Length - 1);
            }
        }
    }
}
