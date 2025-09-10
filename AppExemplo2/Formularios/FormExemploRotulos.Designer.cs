namespace AppExemplo2.Formularios
{
    partial class FormExemploRotulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioAtual = new System.Windows.Forms.TextBox();
            this.txtPercentual = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(500, 46);
            this.label4.TabIndex = 24;
            this.label4.Text = "REAJUSTE SALARIAL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSalarioAtual
            // 
            this.txtSalarioAtual.Location = new System.Drawing.Point(101, 122);
            this.txtSalarioAtual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioAtual.Name = "txtSalarioAtual";
            this.txtSalarioAtual.Size = new System.Drawing.Size(252, 22);
            this.txtSalarioAtual.TabIndex = 25;
            this.txtSalarioAtual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSalarioAtual_KeyUp);
            this.txtSalarioAtual.Leave += new System.EventHandler(this.txtSalarioAtual_Leave_1);
            // 
            // txtPercentual
            // 
            this.txtPercentual.Location = new System.Drawing.Point(101, 193);
            this.txtPercentual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPercentual.Name = "txtPercentual";
            this.txtPercentual.Size = new System.Drawing.Size(252, 22);
            this.txtPercentual.TabIndex = 26;
            this.txtPercentual.TextChanged += new System.EventHandler(this.txtPercentual_TextChanged);
            this.txtPercentual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPercentual_KeyUp);
            this.txtPercentual.Leave += new System.EventHandler(this.txtPercentual_Leave);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(101, 299);
            this.btCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(100, 28);
            this.btCalcular.TabIndex = 27;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            this.btCalcular.Leave += new System.EventHandler(this.txtSalarioAtual_Leave);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(235, 299);
            this.btNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(100, 28);
            this.btNovo.TabIndex = 28;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Salário atual: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Perc (%) reajuste: ";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(97, 356);
            this.lbResultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(123, 16);
            this.lbResultado.TabIndex = 31;
            this.lbResultado.Text = "Salário reajustado: ";
            // 
            // FormExemploRotulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 465);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtPercentual);
            this.Controls.Add(this.txtSalarioAtual);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormExemploRotulos";
            this.Text = "FormExemploRotulos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioAtual;
        private System.Windows.Forms.TextBox txtPercentual;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbResultado;
    }
}