using System;
using System.Windows.Forms;

namespace PPAI2025_3K1_4_1_Programa.Forms
{
    public partial class MenuPrincipalForm : Form
    {
        public MenuPrincipalForm()
        {
            InitializeComponent();
            // Crear y configurar el botón
            Button btnCerrarOrden = new Button();
            btnCerrarOrden.Text = "Cerrar orden de inspección";
            btnCerrarOrden.AutoSize = true;
            btnCerrarOrden.Location = new System.Drawing.Point(30, 30);
            btnCerrarOrden.Click += BtnCerrarOrden_Click;
            this.Controls.Add(btnCerrarOrden);

            this.Text = "Menú Principal";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void BtnCerrarOrden_Click(object sender, EventArgs e)
        {
            // Abrir el formulario de cierre de orden de inspección
            var formCerrarOrden = new CerrarOrdenInspeccionForm();
            formCerrarOrden.ShowDialog();
        }
    }
}