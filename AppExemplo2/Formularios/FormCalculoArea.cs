using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemplo2.Formularios
{
    public partial class FormCalculoArea : Form
    {
        public FormCalculoArea()
        {
            InitializeComponent();
            txtHipotenusa.Visible = false;
            txtArea.Visible = false;
            lbHipoenusa.Visible = false;
            lbArea.Visible = false;
            txtArea.BackColor = Color.LightGreen;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbTipoCalculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;

            switch (tipoCalculo)
            {
                case 0:
                    {
                        txtHipotenusa.Visible = false;
                        lbHipoenusa.Visible = false;

                        txtArea.Visible = true;
                        lbArea.Visible = true;
                        txtCatetoA.BackColor = Color.White;
                        txtCatetoB.BackColor = Color.White;
                        break;

                    }
                case 1:
                    {
                        txtArea.Visible = false;
                        lbArea.Visible = false;

                        txtHipotenusa.Visible = true;
                        lbHipoenusa.Visible = true;
                        txtCatetoA.BackColor = Color.LightGreen;
                        txtCatetoB.BackColor = Color.White;
                        txtHipotenusa.BackColor = Color.White;
                        break;

                    }

            }

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int tipoCalculo = cbTipoCalculo.SelectedIndex;
            double catetoa, catetob, hipotenusa, area;
            switch (tipoCalculo)
            {
                case 0:
                    catetoa = Convert.ToDouble(txtCatetoA.Text);
                    catetob = Convert.ToDouble(txtCatetoB.Text);
                    area = (catetoa * catetob) / 2;
                    txtArea.Text = area.ToString("F2");
                    break;

                case 1:
                    catetob = Convert.ToDouble(txtCatetoB.Text);
                    hipotenusa = Convert.ToDouble(txtHipotenusa.Text);
                    catetob = catetob * catetob;
                    hipotenusa = hipotenusa * hipotenusa;
                    catetoa = Math.Pow((hipotenusa - catetob), 0.5);
                    txtCatetoA.Text = catetoa.ToString("F2");
                    break;
                case 2:
                    catetoa = Convert.ToDouble(txtCatetoA.Text);
                    hipotenusa = Convert.ToDouble(txtHipotenusa.Text);
                    catetoa = catetoa * catetoa;
                    hipotenusa = hipotenusa * hipotenusa;
                    catetoa = Math.Pow((hipotenusa - catetoa), 0.5);
                    txtCatetoB.Text = catetoa.ToString("F2");
                    break;
                case 3:
                    catetoa = Convert.ToDouble(txtCatetoA.Text);
                    catetob = Convert.ToDouble(txtCatetoB.Text);

                    catetoa = catetoa * catetoa;
                    catetob = catetob * catetob;

                    hipotenusa = Math.Pow((catetoa + catetob), 0.5);
                    txtHipotenusa.Text = hipotenusa.ToString("F2");
                    break;
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            txtCatetoA.Clear();
            txtCatetoB.Clear();
            txtHipotenusa.Clear();
            txtArea.Clear();
            txtHipotenusa.Visible = false;
            txtArea.Visible = false;
            lbHipoenusa.Visible = false;
            lbArea.Visible = false;
            txtCatetoA.BackColor = Color.White;
            txtCatetoB.BackColor = Color.White;
            txtHipotenusa.BackColor = Color.White;
            cbTipoCalculo.SelectedIndex = -1;

        }

        private void cbTipoCalculo_Leave(object sender, EventArgs e)
        {



        }

        private void txtCatetoA_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtCatetoA.Text.Count(v => v == ',');
                if (qtdVirgula > 1) verificarNumero = false;

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatetoA.Text = txtCatetoA.Text.Remove(txtCatetoA.Text.Length - 1);
            }
        }

        private void txtCatetoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatetoB_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtCatetoB.Text.Count(v => v == ',');
                if (qtdVirgula > 1) verificarNumero = false;

            }

            if (verificarNumero == false)
            {
                MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCatetoB.Text = txtCatetoB.Text.Remove(txtCatetoB.Text.Length - 1);
            }
        }

        private void txtHipotenusa_KeyUp(object sender, KeyEventArgs e)
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
                int qtdVirgula = txtHipotenusa.Text.Count(v => v == ',');
                if (qtdVirgula > 1) verificarNumero = false;


                if (verificarNumero == false)
                {
                    MessageBox.Show("Somente números", "ADS/JIPA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtHipotenusa.Text = txtHipotenusa.Text.Remove(txtHipotenusa.Text.Length - 1);
                }
            }
        }
    }
}