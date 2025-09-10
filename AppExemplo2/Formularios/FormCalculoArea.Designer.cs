namespace AppExemplo2.Formularios
{
    partial class FormCalculoArea
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
            this.cbTipoCalculo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbHipoenusa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.txtCatetoA = new System.Windows.Forms.TextBox();
            this.txtCatetoB = new System.Windows.Forms.TextBox();
            this.txtHipotenusa = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(440, 37);
            this.label4.TabIndex = 36;
            this.label4.Text = "CÁLCULO TRIÂNGULO RETÂNGULO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbTipoCalculo
            // 
            this.cbTipoCalculo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCalculo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCalculo.FormattingEnabled = true;
            this.cbTipoCalculo.Items.AddRange(new object[] {
            "Calcular área ",
            "Descobrir o valor de (a)",
            "Descobrir o valor de (b)",
            "Descobrir o valor de (c)"});
            this.cbTipoCalculo.Location = new System.Drawing.Point(117, 75);
            this.cbTipoCalculo.Name = "cbTipoCalculo";
            this.cbTipoCalculo.Size = new System.Drawing.Size(167, 21);
            this.cbTipoCalculo.TabIndex = 37;
            this.cbTipoCalculo.SelectedIndexChanged += new System.EventHandler(this.cbTipoCalculo_SelectedIndexChanged);
            this.cbTipoCalculo.Leave += new System.EventHandler(this.cbTipoCalculo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Selecione o tipo de calculo: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbHipoenusa
            // 
            this.lbHipoenusa.AutoSize = true;
            this.lbHipoenusa.Location = new System.Drawing.Point(114, 236);
            this.lbHipoenusa.Name = "lbHipoenusa";
            this.lbHipoenusa.Size = new System.Drawing.Size(104, 13);
            this.lbHipoenusa.TabIndex = 39;
            this.lbHipoenusa.Text = "Lado c (hipotenusa):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Lado B (cateto):\r\n";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Lado A (cateto):\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(114, 294);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(56, 13);
            this.lbArea.TabIndex = 42;
            this.lbArea.Text = "Area (M2):";
            // 
            // txtCatetoA
            // 
            this.txtCatetoA.Location = new System.Drawing.Point(117, 136);
            this.txtCatetoA.Name = "txtCatetoA";
            this.txtCatetoA.Size = new System.Drawing.Size(167, 20);
            this.txtCatetoA.TabIndex = 43;
            this.txtCatetoA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCatetoA_KeyUp);
            // 
            // txtCatetoB
            // 
            this.txtCatetoB.Location = new System.Drawing.Point(117, 194);
            this.txtCatetoB.Name = "txtCatetoB";
            this.txtCatetoB.Size = new System.Drawing.Size(167, 20);
            this.txtCatetoB.TabIndex = 44;
            this.txtCatetoB.TextChanged += new System.EventHandler(this.txtCatetoB_TextChanged);
            this.txtCatetoB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCatetoB_KeyUp);
            // 
            // txtHipotenusa
            // 
            this.txtHipotenusa.Location = new System.Drawing.Point(117, 252);
            this.txtHipotenusa.Name = "txtHipotenusa";
            this.txtHipotenusa.Size = new System.Drawing.Size(167, 20);
            this.txtHipotenusa.TabIndex = 45;
            this.txtHipotenusa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtHipotenusa_KeyUp);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(117, 310);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(167, 20);
            this.txtArea.TabIndex = 46;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(117, 362);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 47;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(209, 362);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 48;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // FormCalculoArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 520);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtHipotenusa);
            this.Controls.Add(this.txtCatetoB);
            this.Controls.Add(this.txtCatetoA);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbHipoenusa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoCalculo);
            this.Controls.Add(this.label4);
            this.Name = "FormCalculoArea";
            this.Text = "FormCalculoArea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbHipoenusa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.TextBox txtCatetoA;
        private System.Windows.Forms.TextBox txtCatetoB;
        private System.Windows.Forms.TextBox txtHipotenusa;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
    }
}