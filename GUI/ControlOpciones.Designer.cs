namespace N1_SimuladorBancario.GUI
{
    partial class ControlOpciones
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
            this.gbxCalculos = new System.Windows.Forms.GroupBox();
            this.btnCDTAbrir = new System.Windows.Forms.Button();
            this.btnCDTCerrar = new System.Windows.Forms.Button();
            this.btnCorrienteConsignar = new System.Windows.Forms.Button();
            this.btnCorrienteRetirar = new System.Windows.Forms.Button();
            this.btnAhorrosConsignar = new System.Windows.Forms.Button();
            this.btnAhorrosRetirar = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.gbxCalculos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCalculos
            // 
            this.gbxCalculos.Controls.Add(this.btnOpcion2);
            this.gbxCalculos.Controls.Add(this.btnOpcion1);
            this.gbxCalculos.Controls.Add(this.btnAhorrosRetirar);
            this.gbxCalculos.Controls.Add(this.btnAhorrosConsignar);
            this.gbxCalculos.Controls.Add(this.btnCorrienteRetirar);
            this.gbxCalculos.Controls.Add(this.btnCorrienteConsignar);
            this.gbxCalculos.Controls.Add(this.btnCDTCerrar);
            this.gbxCalculos.Controls.Add(this.btnCDTAbrir);
            this.gbxCalculos.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCalculos.Location = new System.Drawing.Point(4, 4);
            this.gbxCalculos.Name = "gbxCalculos";
            this.gbxCalculos.Size = new System.Drawing.Size(677, 100);
            this.gbxCalculos.TabIndex = 0;
            this.gbxCalculos.TabStop = false;
            this.gbxCalculos.Text = "Cálculos";
            // 
            // btnCDTAbrir
            // 
            this.btnCDTAbrir.Location = new System.Drawing.Point(20, 28);
            this.btnCDTAbrir.Name = "btnCDTAbrir";
            this.btnCDTAbrir.Size = new System.Drawing.Size(153, 25);
            this.btnCDTAbrir.TabIndex = 0;
            this.btnCDTAbrir.Text = "Abrir Inversión CDT";
            this.btnCDTAbrir.UseVisualStyleBackColor = true;
            this.btnCDTAbrir.Click += new System.EventHandler(this.btnCDTAbrir_Click);
            // 
            // btnCDTCerrar
            // 
            this.btnCDTCerrar.Location = new System.Drawing.Point(20, 61);
            this.btnCDTCerrar.Name = "btnCDTCerrar";
            this.btnCDTCerrar.Size = new System.Drawing.Size(153, 25);
            this.btnCDTCerrar.TabIndex = 1;
            this.btnCDTCerrar.Text = "Cerrar Inversión CDT";
            this.btnCDTCerrar.UseVisualStyleBackColor = true;
            this.btnCDTCerrar.Click += new System.EventHandler(this.btnCDTCerrar_Click);
            // 
            // btnCorrienteConsignar
            // 
            this.btnCorrienteConsignar.Location = new System.Drawing.Point(180, 28);
            this.btnCorrienteConsignar.Name = "btnCorrienteConsignar";
            this.btnCorrienteConsignar.Size = new System.Drawing.Size(202, 25);
            this.btnCorrienteConsignar.TabIndex = 2;
            this.btnCorrienteConsignar.Text = "Consignar cuenta corriente";
            this.btnCorrienteConsignar.UseVisualStyleBackColor = true;
            this.btnCorrienteConsignar.Click += new System.EventHandler(this.btnCorrienteConsignar_Click);
            // 
            // btnCorrienteRetirar
            // 
            this.btnCorrienteRetirar.Location = new System.Drawing.Point(180, 60);
            this.btnCorrienteRetirar.Name = "btnCorrienteRetirar";
            this.btnCorrienteRetirar.Size = new System.Drawing.Size(202, 26);
            this.btnCorrienteRetirar.TabIndex = 3;
            this.btnCorrienteRetirar.Text = "Retirar cuenta corriente";
            this.btnCorrienteRetirar.UseVisualStyleBackColor = true;
            this.btnCorrienteRetirar.Click += new System.EventHandler(this.btnCorrienteRetirar_Click);
            // 
            // btnAhorrosConsignar
            // 
            this.btnAhorrosConsignar.Location = new System.Drawing.Point(388, 28);
            this.btnAhorrosConsignar.Name = "btnAhorrosConsignar";
            this.btnAhorrosConsignar.Size = new System.Drawing.Size(171, 25);
            this.btnAhorrosConsignar.TabIndex = 4;
            this.btnAhorrosConsignar.Text = "Consignar cuenta ahorro";
            this.btnAhorrosConsignar.UseVisualStyleBackColor = true;
            this.btnAhorrosConsignar.Click += new System.EventHandler(this.btnAhorrosConsignar_Click);
            // 
            // btnAhorrosRetirar
            // 
            this.btnAhorrosRetirar.Location = new System.Drawing.Point(389, 60);
            this.btnAhorrosRetirar.Name = "btnAhorrosRetirar";
            this.btnAhorrosRetirar.Size = new System.Drawing.Size(170, 26);
            this.btnAhorrosRetirar.TabIndex = 5;
            this.btnAhorrosRetirar.Text = "Retirar cuenta ahorro";
            this.btnAhorrosRetirar.UseVisualStyleBackColor = true;
            this.btnAhorrosRetirar.Click += new System.EventHandler(this.btnAhorrosRetirar_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(566, 28);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(87, 25);
            this.btnOpcion1.TabIndex = 6;
            this.btnOpcion1.Text = "Opción 1";
            this.btnOpcion1.UseVisualStyleBackColor = true;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(566, 60);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(87, 26);
            this.btnOpcion2.TabIndex = 7;
            this.btnOpcion2.Text = "Opción 2";
            this.btnOpcion2.UseVisualStyleBackColor = true;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // ControlOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxCalculos);
            this.Name = "ControlOpciones";
            this.Size = new System.Drawing.Size(684, 108);
            this.gbxCalculos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCalculos;
        private System.Windows.Forms.Button btnCDTCerrar;
        private System.Windows.Forms.Button btnCDTAbrir;
        private System.Windows.Forms.Button btnCorrienteRetirar;
        private System.Windows.Forms.Button btnCorrienteConsignar;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnAhorrosRetirar;
        private System.Windows.Forms.Button btnAhorrosConsignar;
    }
}
