namespace N1_SimuladorBancario.GUI
{
    partial class ControlDatosCliente
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
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lblMesActual = new System.Windows.Forms.Label();
            this.txtMesActual = new System.Windows.Forms.TextBox();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.gbxDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.Controls.Add(this.btnAvanzar);
            this.gbxDatosPersonales.Controls.Add(this.txtMesActual);
            this.gbxDatosPersonales.Controls.Add(this.lblMesActual);
            this.gbxDatosPersonales.Controls.Add(this.txtCedula);
            this.gbxDatosPersonales.Controls.Add(this.lblCedula);
            this.gbxDatosPersonales.Controls.Add(this.txtNombre);
            this.gbxDatosPersonales.Controls.Add(this.lblNombre);
            this.gbxDatosPersonales.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosPersonales.Location = new System.Drawing.Point(4, 4);
            this.gbxDatosPersonales.Name = "gbxDatosPersonales";
            this.gbxDatosPersonales.Size = new System.Drawing.Size(680, 84);
            this.gbxDatosPersonales.TabIndex = 0;
            this.gbxDatosPersonales.TabStop = false;
            this.gbxDatosPersonales.Text = "Datos Personales";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(97, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 18);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(154, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(314, 38);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(49, 18);
            this.lblCedula.TabIndex = 2;
            this.lblCedula.Text = "Cédula:";
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(371, 36);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(117, 21);
            this.txtCedula.TabIndex = 3;
            // 
            // lblMesActual
            // 
            this.lblMesActual.AutoSize = true;
            this.lblMesActual.Location = new System.Drawing.Point(504, 38);
            this.lblMesActual.Name = "lblMesActual";
            this.lblMesActual.Size = new System.Drawing.Size(34, 18);
            this.lblMesActual.TabIndex = 4;
            this.lblMesActual.Text = "Mes:";
            // 
            // txtMesActual
            // 
            this.txtMesActual.Enabled = false;
            this.txtMesActual.Location = new System.Drawing.Point(544, 36);
            this.txtMesActual.Name = "txtMesActual";
            this.txtMesActual.Size = new System.Drawing.Size(39, 21);
            this.txtMesActual.TabIndex = 5;
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(598, 33);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(52, 23);
            this.btnAvanzar.TabIndex = 6;
            this.btnAvanzar.Text = "»";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // ControlDatosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxDatosPersonales);
            this.Name = "ControlDatosCliente";
            this.Size = new System.Drawing.Size(684, 91);
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxDatosPersonales;
        private System.Windows.Forms.TextBox txtMesActual;
        private System.Windows.Forms.Label lblMesActual;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAvanzar;
    }
}
