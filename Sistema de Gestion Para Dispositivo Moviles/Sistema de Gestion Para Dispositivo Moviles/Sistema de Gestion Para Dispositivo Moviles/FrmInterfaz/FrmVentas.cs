using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Clases;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz
{
    public partial class FrmVentas : Form
    {


        CD_Conexion con = new CD_Conexion();
        //CN_Ventas objetoCN = new CN_Ventas();
        

        //private bool ver = false;
        

        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            MostrarVenta();
        }

        private void btnAgrVenta_Click(object sender, EventArgs e)
        {
            FrmEmgVentas frm = new FrmEmgVentas();
            //frm.setEditar(false);
            AbrirFormInPanel(new FrmEmgVentas());
            MostrarVenta();
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            Form fh = Formhijo as Form;
            fh.ShowDialog();
        }
        private void MostrarVenta()
        {
            CN_Ventas objeto = new CN_Ventas();
            dgvVentas.DataSource = objeto.MostrarVenta();
        }

        private void btnMostrarDetalle_Click(object sender, EventArgs e)
        {
            FrmEmgDetalleVenta frm = new FrmEmgDetalleVenta();
            if (dgvVentas.SelectedRows.Count > 0)
            {
                frm.IdVentas = dgvVentas.CurrentRow.Cells["Idventa"].Value.ToString();
                frm.txtTipoDocumentoDetalle.Text = dgvVentas.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                frm.txtDocumentoCliente.Text = dgvVentas.CurrentRow.Cells["NumeroDocumento"].Value.ToString();
                frm.txtNombreClienteDetalle.Text = dgvVentas.CurrentRow.Cells["Nombrecliente"].Value.ToString();
                frm.txtMontoTotalDetalleVenta.Text = dgvVentas.CurrentRow.Cells["MontoTotal"].Value.ToString();
                frm.txtMontoPagoDetalleVenta.Text = dgvVentas.CurrentRow.Cells["MontoPago"].Value.ToString();
                frm.txtMontoCambioDetalleVenta.Text = dgvVentas.CurrentRow.Cells["MontoCambio"].Value.ToString();
                frm.txtFechaDetalle.Text = dgvVentas.CurrentRow.Cells["FechaRegistro"].Value.ToString();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
}
