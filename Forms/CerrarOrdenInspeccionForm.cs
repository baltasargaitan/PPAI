using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PPAI2025_3K1_4_1_Programa.Controladores;

namespace PPAI2025_3K1_4_1_Programa.Forms
{
    public partial class CerrarOrdenInspeccionForm : Form
    {
        private OrdenInspeccion ordenSeleccionada;
        private GestorCierreInspeccion controlador;

        public CerrarOrdenInspeccionForm(GestorCierreInspeccion controlador)
        {
            InitializeComponent();
            this.controlador = controlador;
            this.Load += CerrarOrdenInspeccionForm_Load;
        }

        private void CerrarOrdenInspeccionForm_Load(object sender, EventArgs e)
        {
            dgvOrdenes.DataSource = controlador.ObtenerOrdenesCompletadasDelRI();
            dgvOrdenes.ClearSelection();
            rbOnline.Checked = true;
            clbMotivos.Enabled = false;
            pnlMotivosComentarios.Enabled = false;
        }

        private void dgvOrdenes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrdenes.SelectedRows.Count > 0)
            {
                ordenSeleccionada = (OrdenInspeccion)dgvOrdenes.SelectedRows[0].DataBoundItem;
                lblNumeroOrden.Text = ordenSeleccionada.Numero.ToString();
                lblFechaFinalizacion.Text = ordenSeleccionada.FechaFinalizacion.ToShortDateString();
                lblEstacion.Text = ordenSeleccionada.EstacionSismologica.Nombre;
                lblSismografo.Text = ordenSeleccionada.EstacionSismologica.Sismografo.IdentificadorSismografo.ToString();
                txtObservacion.Text = "";
                rbOnline.Checked = true;
                clbMotivos.ClearSelected();
                pnlMotivosComentarios.Controls.Clear();
            }
        }

        private void rbOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOnline.Checked)
            {
                clbMotivos.Enabled = false;
                pnlMotivosComentarios.Enabled = false;
            }
        }

        private void rbFueraDeServicio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFueraDeServicio.Checked)
            {
                clbMotivos.Enabled = true;
                pnlMotivosComentarios.Enabled = true;
                if (clbMotivos.Items.Count == 0)
                {
                    var motivos = controlador.ObtenerMotivosFueraDeServicio();
                    foreach (var motivo in motivos)
                        clbMotivos.Items.Add(motivo);
                }
            }
        }

        private void clbMotivos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                pnlMotivosComentarios.Controls.Clear();
                foreach (var item in clbMotivos.CheckedItems)
                {
                    var lbl = new Label() { Text = item.ToString(), AutoSize = true };
                    var txt = new TextBox() { Name = "txtComentario_" + item.ToString(), Width = 200 };
                    pnlMotivosComentarios.Controls.Add(lbl);
                    pnlMotivosComentarios.Controls.Add(txt);
                }

                if (e.NewValue == CheckState.Checked)
                {
                    var motivo = clbMotivos.Items[e.Index].ToString();
                    var lbl = new Label() { Text = motivo, AutoSize = true };
                    var txt = new TextBox() { Name = "txtComentario_" + motivo, Width = 200 };
                    pnlMotivosComentarios.Controls.Add(lbl);
                    pnlMotivosComentarios.Controls.Add(txt);
                }
            });
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ordenSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una orden.", "Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                MessageBox.Show("Debe ingresar una observación de cierre.", "Error");
                return;
            }

            if (rbFueraDeServicio.Checked)
            {
                if (clbMotivos.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar al menos un motivo.", "Error");
                    return;
                }

                foreach (var item in clbMotivos.CheckedItems)
                {
                    var txt = pnlMotivosComentarios.Controls["txtComentario_" + item.ToString()] as TextBox;
                    if (txt == null || string.IsNullOrWhiteSpace(txt.Text))
                    {
                        MessageBox.Show($"Debe ingresar un comentario para el motivo '{item}'.", "Error");
                        return;
                    }
                }
            }

            var result = MessageBox.Show("¿Está seguro de cerrar la orden?", "Confirmar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var motivosComentarios = new List<MotivoComentario>();
                if (rbFueraDeServicio.Checked)
                {
                    foreach (var item in clbMotivos.CheckedItems)
                    {
                        var txt = pnlMotivosComentarios.Controls["txtComentario_" + item.ToString()] as TextBox;
                        motivosComentarios.Add(new MotivoComentario
                        {
                            Motivo = item.ToString(),
                            Comentario = txt.Text
                        });
                    }
                }

                controlador.CerrarOrden(
                    ordenSeleccionada,
                    txtObservacion.Text,
                    rbFueraDeServicio.Checked,
                    motivosComentarios
                );

                MessageBox.Show("Orden cerrada correctamente.", "Éxito");
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.dgvOrdenes = new System.Windows.Forms.DataGridView();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.rbOnline = new System.Windows.Forms.RadioButton();
            this.rbFueraDeServicio = new System.Windows.Forms.RadioButton();
            this.clbMotivos = new System.Windows.Forms.CheckedListBox();
            this.pnlMotivosComentarios = new System.Windows.Forms.Panel();
            this.lblNumeroOrden = new System.Windows.Forms.Label();
            this.lblFechaFinalizacion = new System.Windows.Forms.Label();
            this.lblEstacion = new System.Windows.Forms.Label();
            this.lblSismografo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrdenes
            // 
            this.dgvOrdenes.Location = new System.Drawing.Point(0, 0);
            this.dgvOrdenes.Name = "dgvOrdenes";
            this.dgvOrdenes.Size = new System.Drawing.Size(240, 150);
            this.dgvOrdenes.TabIndex = 0;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(0, 0);
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(100, 20);
            this.txtObservacion.TabIndex = 0;
            // 
            // rbOnline
            // 
            this.rbOnline.Location = new System.Drawing.Point(0, 0);
            this.rbOnline.Name = "rbOnline";
            this.rbOnline.Size = new System.Drawing.Size(104, 24);
            this.rbOnline.TabIndex = 0;
            // 
            // rbFueraDeServicio
            // 
            this.rbFueraDeServicio.Location = new System.Drawing.Point(0, 0);
            this.rbFueraDeServicio.Name = "rbFueraDeServicio";
            this.rbFueraDeServicio.Size = new System.Drawing.Size(104, 24);
            this.rbFueraDeServicio.TabIndex = 0;
            // 
            // clbMotivos
            // 
            this.clbMotivos.Location = new System.Drawing.Point(0, 0);
            this.clbMotivos.Name = "clbMotivos";
            this.clbMotivos.Size = new System.Drawing.Size(120, 96);
            this.clbMotivos.TabIndex = 0;
            // 
            // pnlMotivosComentarios
            // 
            this.pnlMotivosComentarios.Location = new System.Drawing.Point(0, 0);
            this.pnlMotivosComentarios.Name = "pnlMotivosComentarios";
            this.pnlMotivosComentarios.Size = new System.Drawing.Size(200, 100);
            this.pnlMotivosComentarios.TabIndex = 0;
            // 
            // lblNumeroOrden
            // 
            this.lblNumeroOrden.Location = new System.Drawing.Point(0, 0);
            this.lblNumeroOrden.Name = "lblNumeroOrden";
            this.lblNumeroOrden.Size = new System.Drawing.Size(100, 23);
            this.lblNumeroOrden.TabIndex = 0;
            // 
            // lblFechaFinalizacion
            // 
            this.lblFechaFinalizacion.Location = new System.Drawing.Point(0, 0);
            this.lblFechaFinalizacion.Name = "lblFechaFinalizacion";
            this.lblFechaFinalizacion.Size = new System.Drawing.Size(100, 23);
            this.lblFechaFinalizacion.TabIndex = 0;
            // 
            // lblEstacion
            // 
            this.lblEstacion.Location = new System.Drawing.Point(0, 0);
            this.lblEstacion.Name = "lblEstacion";
            this.lblEstacion.Size = new System.Drawing.Size(100, 23);
            this.lblEstacion.TabIndex = 0;
            // 
            // lblSismografo
            // 
            this.lblSismografo.Location = new System.Drawing.Point(0, 0);
            this.lblSismografo.Name = "lblSismografo";
            this.lblSismografo.Size = new System.Drawing.Size(100, 23);
            this.lblSismografo.TabIndex = 0;
            // 
            // CerrarOrdenInspeccionForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "CerrarOrdenInspeccionForm";
            this.Load += new System.EventHandler(this.CerrarOrdenInspeccionForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenes)).EndInit();
            this.ResumeLayout(false);

        }

        // Controles privados añadidos manualmente
        private DataGridView dgvOrdenes;
        private TextBox txtObservacion;
        private RadioButton rbOnline;
        private RadioButton rbFueraDeServicio;
        private CheckedListBox clbMotivos;
        private Panel pnlMotivosComentarios;
        private Label lblNumeroOrden;
        private Label lblFechaFinalizacion;
        private Label lblEstacion;
        private Label lblSismografo;

        private void CerrarOrdenInspeccionForm_Load_1(object sender, EventArgs e)
        {

        }
    }

    public class MotivoComentario
    {
        public string Motivo { get; set; }
        public string Comentario { get; set; }
    }

    // Asegurate de que existan las clases OrdenInspeccion, EstacionSismologica, etc. en tu proyecto.
}
