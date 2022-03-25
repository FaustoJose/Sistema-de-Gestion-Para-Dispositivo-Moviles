using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz
{
    public partial class FrmCliente : Form
    {
        CN_Clientes objetoCN = new CN_Clientes();
        private string IdCliente = null;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnCerraInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            MostrarCliente();
        }

        private void MostrarCliente()
        {
            CN_Clientes objeto = new CN_Clientes();
            dgvClientes.DataSource = objeto.MostrarCliente();
        }

        private void btnAgregarClien_Click(object sender, EventArgs e)
        {
            FrmEmgCliente frm = new FrmEmgCliente();
            frm.setEditar(false);
            AbrirFormInPanel(new FrmEmgCliente());
            MostrarCliente();
        }

        private void AbrirFormInPanel(object Formhijo)
        {
            Form fh = Formhijo as Form;
            fh.ShowDialog();
        }

        private void btnEditarClien_Click(object sender, EventArgs e)
        {
            FrmEmgCliente frm = new FrmEmgCliente();
            if (dgvClientes.SelectedRows.Count > 0)
            {

                frm.EditarTrue();
                frm.IdCliente = dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString();
                frm.txtDocumento.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombre.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                frm.txtCorreo.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                frm.txtTelefono.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
                frm.cbCategoria.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
                frm.cbDescuento.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
                frm.chbEstado.Checked = (bool)dgvClientes.CurrentRow.Cells[7].Value;
                frm.ShowDialog();
                MostrarCliente();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnEliminarClien_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                IdCliente = dgvClientes.CurrentRow.Cells["IdCliente"].Value.ToString();
                objetoCN.EliminarCliente(IdCliente);
                MessageBox.Show("Eliminado correctamente");
                MostrarCliente();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    
}
