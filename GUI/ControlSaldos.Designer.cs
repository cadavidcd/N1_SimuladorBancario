namespace N1_SimuladorBancario.GUI
{
    partial class ControlSaldos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSaldo = new System.Windows.Forms.GroupBox();
            this.lblSaldoCorriente = new System.Windows.Forms.Label();
            this.txtSaldoCorriente = new System.Windows.Forms.TextBox();
            this.lblSaldoAhorros = new System.Windows.Forms.Label();
            this.txtSaldoAhorros = new System.Windows.Forms.TextBox();
            this.lblSaldoCdt = new System.Windows.Forms.Label();
            this.txtSaldoCdt = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSaldoTotal = new System.Windows.Forms.TextBox();
            this.gbxSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxSaldo
            // 
            this.gbxSaldo.Controls.Add(this.txtSaldoTotal);
            this.gbxSaldo.Controls.Add(this.lblTotal);
            this.gbxSaldo.Controls.Add(this.txtSaldoCdt);
            this.gbxSaldo.Controls.Add(this.lblSaldoCdt);
            this.gbxSaldo.Controls.Add(this.txtSaldoAhorros);
            this.gbxSaldo.Controls.Add(this.lblSaldoAhorros);
            this.gbxSaldo.Controls.Add(this.txtSaldoCorriente);
            this.gbxSaldo.Controls.Add(this.lblSaldoCorriente);
            this.gbxSaldo.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSaldo.Location = new System.Drawing.Point(4, 0);
            this.gbxSaldo.Name = "gbxSaldo";
            this.gbxSaldo.Size = new System.Drawing.Size(677, 144);
            this.gbxSaldo.TabIndex = 0;
            this.gbxSaldo.TabStop = false;
            this.gbxSaldo.Text = "Saldo";
            // 
            // lblSaldoCorriente
            // 
            this.lblSaldoCorriente.AutoSize = true;
            this.lblSaldoCorriente.Location = new System.Drawing.Point(120, 35);
            this.lblSaldoCorriente.Name = "lblSaldoCorriente";
            this.lblSaldoCorriente.Size = new System.Drawing.Size(98, 18);
            this.lblSaldoCorriente.TabIndex = 0;
            this.lblSaldoCorriente.Text = "Saldo Corriente:";
            // 
            // txtSaldoCorriente
            // 
            this.txtSaldoCorriente.Location = new System.Drawing.Point(232, 34);
            this.txtSaldoCorriente.Name = "txtSaldoCorriente";
            this.txtSaldoCorriente.Size = new System.Drawing.Size(145, 21);
            this.txtSaldoCorriente.TabIndex = 1;
            // 
            // lblSaldoAhorros
            // 
            this.lblSaldoAhorros.AutoSize = true;
            this.lblSaldoAhorros.Location = new System.Drawing.Point(120, 70);
            this.lblSaldoAhorros.Name = "lblSaldoAhorros";
            this.lblSaldoAhorros.Size = new System.Drawing.Size(88, 18);
            this.lblSaldoAhorros.TabIndex = 2;
            this.lblSaldoAhorros.Text = "Saldo Ahorros:";
            // 
            // txtSaldoAhorros
            // 
            this.txtSaldoAhorros.Location = new System.Drawing.Point(232, 67);
            this.txtSaldoAhorros.Name = "txtSaldoAhorros";
            this.txtSaldoAhorros.Size = new System.Drawing.Size(145, 21);
            this.txtSaldoAhorros.TabIndex = 3;
            // 
            // lblSaldoCdt
            // 
            this.lblSaldoCdt.AutoSize = true;
            this.lblSaldoCdt.Location = new System.Drawing.Point(120, 101);
            this.lblSaldoCdt.Name = "lblSaldoCdt";
            this.lblSaldoCdt.Size = new System.Drawing.Size(66, 18);
            this.lblSaldoCdt.TabIndex = 4;
            this.lblSaldoCdt.Text = "Saldo CDT:";
            // 
            // txtSaldoCdt
            // 
            this.txtSaldoCdt.Location = new System.Drawing.Point(232, 98);
            this.txtSaldoCdt.Name = "txtSaldoCdt";
            this.txtSaldoCdt.Size = new System.Drawing.Size(145, 21);
            this.txtSaldoCdt.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(411, 99);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 18);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // txtSaldoTotal
            // 
            this.txtSaldoTotal.Location = new System.Drawing.Point(458, 98);
            this.txtSaldoTotal.Name = "txtSaldoTotal";
            this.txtSaldoTotal.Size = new System.Drawing.Size(114, 21);
            this.txtSaldoTotal.TabIndex = 7;
            // 
            // ControlSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxSaldo);
            this.Name = "ControlSaldos";
            this.Size = new System.Drawing.Size(684, 147);
            this.gbxSaldo.ResumeLayout(false);
            this.gbxSaldo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSaldo;
        private System.Windows.Forms.TextBox txtSaldoTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSaldoCdt;
        private System.Windows.Forms.Label lblSaldoCdt;
        private System.Windows.Forms.TextBox txtSaldoAhorros;
        private System.Windows.Forms.Label lblSaldoAhorros;
        private System.Windows.Forms.TextBox txtSaldoCorriente;
        private System.Windows.Forms.Label lblSaldoCorriente;
    }
}
