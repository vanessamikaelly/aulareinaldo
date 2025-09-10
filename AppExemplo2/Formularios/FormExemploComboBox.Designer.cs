namespace AppExemplo2.Formularios
{
    partial class FormExemploComboBox
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
            this.cbTipoCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPecentual = new System.Windows.Forms.Label();
            this.txtPercDesconto = new System.Windows.Forms.TextBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 37);
            this.label4.TabIndex = 25;
            this.label4.Text = "SISTEMA DE DESCONTOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTipoCliente
            // 
            this.cbTipoCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbTipoCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTipoCliente.FormattingEnabled = true;
            this.cbTipoCliente.Items.AddRange(new object[] {
            "Cliente Diamante: 25 %",
            "Cliente Ouro: 20%",
            "Cliente VIP: 15%",
            "Cliente Comum: 10%",
            "Cliente Aleatório: (Percentual Livre)"});
            this.cbTipoCliente.Location = new System.Drawing.Point(70, 101);
            this.cbTipoCliente.Name = "cbTipoCliente";
            this.cbTipoCliente.Size = new System.Drawing.Size(206, 21);
            this.cbTipoCliente.TabIndex = 26;
            this.cbTipoCliente.SelectedIndexChanged += new System.EventHandler(this.cbTipoCliente_SelectedIndexChanged);
            this.cbTipoCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbTipoCliente_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Selecione o tipo de cliente\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtValorCompra
            // 
            this.txtValorCompra.Location = new System.Drawing.Point(70, 185);
            this.txtValorCompra.Name = "txtValorCompra";
            this.txtValorCompra.Size = new System.Drawing.Size(206, 20);
            this.txtValorCompra.TabIndex = 28;
            this.txtValorCompra.TextChanged += new System.EventHandler(this.txtValorCompra_TextChanged);
            this.txtValorCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtValorCompra_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Valor da compra";
            // 
            // lbPecentual
            // 
            this.lbPecentual.AutoSize = true;
            this.lbPecentual.Location = new System.Drawing.Point(67, 232);
            this.lbPecentual.Name = "lbPecentual";
            this.lbPecentual.Size = new System.Drawing.Size(99, 13);
            this.lbPecentual.TabIndex = 30;
            this.lbPecentual.Text = "Perc (%) desconto: ";
            // 
            // txtPercDesconto
            // 
            this.txtPercDesconto.Location = new System.Drawing.Point(70, 257);
            this.txtPercDesconto.Name = "txtPercDesconto";
            this.txtPercDesconto.Size = new System.Drawing.Size(206, 20);
            this.txtPercDesconto.TabIndex = 31;
            this.txtPercDesconto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPercDesconto_KeyUp);
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(70, 322);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 32;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // btNovo
            // 
            this.btNovo.Location = new System.Drawing.Point(183, 322);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(75, 23);
            this.btNovo.TabIndex = 33;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(70, 417);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(206, 20);
            this.txtResultado.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 391);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Valor com desconto";
            // 
            // FormExemploComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btNovo);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.txtPercDesconto);
            this.Controls.Add(this.lbPecentual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorCompra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoCliente);
            this.Controls.Add(this.label4);
            this.Name = "FormExemploComboBox";
            this.Text = "FormExemploComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTipoCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPecentual;
        private System.Windows.Forms.TextBox txtPercDesconto;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label5;
    }
}