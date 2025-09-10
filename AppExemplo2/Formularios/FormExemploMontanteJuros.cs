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
    public partial class FormEexmploMontanteJuros : Form
    {
        public FormEexmploMontanteJuros()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void FormEexmploMontanteJuros_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcaoSelecionada = cbEscolha.SelectedIndex;
            switch (opcaoSelecionada)
            {
                case 0:
                    txtTempo.Visible = true;
                    txtCapital.Visible = true;
                    txtJuros.Visible = true;
                    txtTaxa.Visible = true;
                    txtMontante.Visible = true;

                    txtTempo.BackColor = Color.White;
                    txtJuros.BackColor = Color.White;
                    txtCapital.BackColor = Color.White;
                    txtTaxa.BackColor = Color.White;

                    txtMontante.BackColor = Color.LightGreen;
                    break;

                case 1:
                    txtMontante.Visible = true;
                    txtTempo.Visible = true;
                    txtTaxa.Visible = true;
                    txtCapital.Visible = true;
                    txtJuros.Visible = true;

                    txtTempo.BackColor = Color.White;
                    txtMontante.BackColor = Color.White;
                    txtJuros.BackColor = Color.White;
                    txtTaxa.BackColor = Color.White;

                    txtCapital.BackColor = Color.LightGreen;
                    break;

                case 2:
                    txtJuros.Visible = true;
                    txtTempo.Visible = true;
                    txtMontante.Visible = true;
                    txtCapital.Visible = true;
                    txtTaxa.Visible = true;

                    txtTempo.BackColor = Color.White;
                    txtMontante.BackColor = Color.White;
                    txtJuros.BackColor = Color.White;
                    txtCapital.BackColor = Color.White;

                    txtTaxa.BackColor = Color.LightGreen;
                    break;

                case 3:
                    txtTaxa.Visible = true;
                    txtMontante.Visible = true;
                    txtJuros.Visible = true;
                    txtCapital.Visible = true;
                    txtTempo.Visible = true;

                    txtCapital.BackColor = Color.White;
                    txtTaxa.BackColor = Color.White;
                    txtMontante.BackColor = Color.White;
                    txtJuros.BackColor = Color.White;

                    txtTempo.BackColor = Color.LightGreen;
                    break;
            }

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int opcaoSelecionada = cbEscolha.SelectedIndex;
            double resultado = 0, juros = 0, capital, taxa, tempo, montante;

            switch (opcaoSelecionada)
            { 

                case 0:

                    capital = Convert.ToDouble(txtCapital.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text) / 100;
                    tempo = Convert.ToDouble(txtTempo.Text);

                    resultado = capital * (1 + (taxa * tempo));
                    juros = resultado - capital;

                    txtMontante.Text = resultado.ToString("F2");
                    txtJuros.Text = juros.ToString("F2");

                    break;

                case 1:

                    montante = Convert.ToDouble(txtMontante.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text) / 100;
                    tempo = Convert.ToDouble(txtTempo.Text);

                    resultado = montante / (1 + (taxa * tempo));
                    juros = montante - resultado;

                    txtCapital.Text = resultado.ToString("F2");
                    txtJuros.Text = juros.ToString("F2");

                    break;

                case 2:

                    montante = Convert.ToDouble(txtMontante.Text);
                    capital = Convert.ToDouble(txtCapital.Text);
                    tempo = Convert.ToDouble(txtTempo.Text);

                    resultado = (montante - capital) / (capital * tempo);
                    juros = montante - capital;

                    txtTaxa.Text = (resultado * 100).ToString("F2"); // convertendo pra porcentagem
                    txtJuros.Text = juros.ToString("F2");

                    break;

                case 3:

                    montante = Convert.ToDouble(txtMontante.Text);
                    capital = Convert.ToDouble(txtCapital.Text);
                    taxa = Convert.ToDouble(txtTaxa.Text) / 100;

                    resultado = (montante - capital) / (capital * taxa);
                    juros = montante - capital;

                    txtTempo.Text = resultado.ToString("F2");
                    txtJuros.Text = juros.ToString("F2");

                    break;
            }
        }

        private void txtMontante_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtMontante.Text.Count(v => v == ','); 
                if (qtdVirgula > 1) verificarNum = false;
                                                           
            }

            if (verificarNum == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontante.Text = txtMontante.Text.Remove(txtMontante.Text.Length - 1);
            }
        }

        private void txtCapital_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtCapital.Text.Count(v => v == ','); 
                if (qtdVirgula > 1) verificarNum = false;
                                                            
            }

            if (verificarNum == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCapital.Text = txtCapital.Text.Remove(txtCapital.Text.Length - 1);
            }
        }

        private void txtTaxa_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtTaxa.Text.Count(v => v == ','); 
                if (qtdVirgula > 1) verificarNum = false;
                                                           
            }

            if (verificarNum == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaxa.Text = txtTaxa.Text.Remove(txtTaxa.Text.Length - 1);
            }
        }

        private void txtTempo_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtTempo.Text.Count(v => v == ','); 
                if (qtdVirgula > 1) verificarNum = false;
                                                            
            }

            if (verificarNum == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTempo.Text = txtTempo.Text.Remove(txtTempo.Text.Length - 1);
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {

            txtMontante.Clear();
            txtCapital.Clear();
            txtTaxa.Clear();
            txtTempo.Clear();
            txtJuros.Clear();
            cbEscolha.Select();
        }
    }
}
