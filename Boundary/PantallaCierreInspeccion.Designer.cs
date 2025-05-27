namespace PPAI2025_3K1_4_1_Programa.Boundary
{
    partial class PantallaCierreInspeccion
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
            this.btnOpcCerrarInspecciones = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOpcCerrarInspecciones
            // 
            this.btnOpcCerrarInspecciones.Location = new System.Drawing.Point(338, 269);
            this.btnOpcCerrarInspecciones.Name = "btnOpcCerrarInspecciones";
            this.btnOpcCerrarInspecciones.Size = new System.Drawing.Size(93, 55);
            this.btnOpcCerrarInspecciones.TabIndex = 0;
            this.btnOpcCerrarInspecciones.Text = "Cierre de Inspeccion";
            this.btnOpcCerrarInspecciones.UseVisualStyleBackColor = true;
            this.btnOpcCerrarInspecciones.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Bienvenido a la pantalla de Cierre de Inspeccion";
            // 
            // PantallaCierreInspeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpcCerrarInspecciones);
            this.Name = "PantallaCierreInspeccion";
            this.Text = "PantallaCierreInspeccion";
            this.Load += new System.EventHandler(this.PantallaCierreInspeccion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpcCerrarInspecciones;
        private System.Windows.Forms.TextBox textBox1;
    }
}