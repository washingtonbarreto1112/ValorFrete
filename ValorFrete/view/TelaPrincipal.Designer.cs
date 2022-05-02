
namespace ValorFrete.view
{
    partial class TelaPrincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblValorFrete = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.tbxCliente = new System.Windows.Forms.TextBox();
            this.tbxValor = new System.Windows.Forms.TextBox();
            this.tbxFrete = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo de Frete";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(63, 113);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(47, 15);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(63, 174);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(36, 15);
            this.lblValor.TabIndex = 2;
            this.lblValor.Text = "Valor:";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(63, 238);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(46, 15);
            this.lblFrete.TabIndex = 3;
            this.lblFrete.Text = "% Frete";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(431, 169);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(24, 15);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "UF:";
            this.lblUF.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblValorFrete
            // 
            this.lblValorFrete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblValorFrete.Location = new System.Drawing.Point(132, 308);
            this.lblValorFrete.Name = "lblValorFrete";
            this.lblValorFrete.Size = new System.Drawing.Size(481, 111);
            this.lblValorFrete.TabIndex = 5;
            this.lblValorFrete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(470, 234);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // cboUF
            // 
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(470, 161);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(121, 23);
            this.cboUF.TabIndex = 7;
            // 
            // tbxCliente
            // 
            this.tbxCliente.Location = new System.Drawing.Point(175, 105);
            this.tbxCliente.Name = "tbxCliente";
            this.tbxCliente.Size = new System.Drawing.Size(491, 23);
            this.tbxCliente.TabIndex = 8;
            // 
            // tbxValor
            // 
            this.tbxValor.Location = new System.Drawing.Point(175, 166);
            this.tbxValor.Name = "tbxValor";
            this.tbxValor.Size = new System.Drawing.Size(151, 23);
            this.tbxValor.TabIndex = 9;
            // 
            // tbxFrete
            // 
            this.tbxFrete.Location = new System.Drawing.Point(175, 230);
            this.tbxFrete.Name = "tbxFrete";
            this.tbxFrete.Size = new System.Drawing.Size(151, 23);
            this.tbxFrete.TabIndex = 10;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.tbxFrete);
            this.Controls.Add(this.tbxValor);
            this.Controls.Add(this.tbxCliente);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblValorFrete);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblFrete);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Cálculo e Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblValorFrete;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox tbxCliente;
        private System.Windows.Forms.TextBox tbxValor;
        private System.Windows.Forms.TextBox tbxFrete;
    }
}