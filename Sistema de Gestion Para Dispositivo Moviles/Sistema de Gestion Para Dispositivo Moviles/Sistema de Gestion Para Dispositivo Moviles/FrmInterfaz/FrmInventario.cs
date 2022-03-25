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

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles
{
    public partial class FrmInventario : Form
    {
        //objetos

        CN_Inventario objetoCN = new CN_Inventario();
        //FrmEmgInventario frm = new FrmEmgInventario();



        private string IdProducto = null;
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
           
            
        }

     
        private void MostrarProdctos()
        {
            CN_Inventario objeto = new CN_Inventario();
            dgvInventario.DataSource = objeto.MostrarProd();
        }
       

        private void btnCerraInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarPro_Click(object sender, EventArgs e)
        {
            FrmEmgInventario frm = new FrmEmgInventario();
            frm.setEditar(false);
            AbrirFormInPanel(new FrmEmgInventario());
            MostrarProdctos();
        }


        private void AbrirFormInPanel(object Formhijo)
        {
            
            Form fh = Formhijo as Form;
            fh.ShowDialog();

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            FrmEmgInventario frm = new FrmEmgInventario();
            if (dgvInventario.SelectedRows.Count > 0)
            {
                


                frm.EditarTrue();
                frm.IdProducto = dgvInventario.CurrentRow.Cells["IdProducto"].Value.ToString();
                frm.txtCodigo.Text = dgvInventario.CurrentRow.Cells[1].Value.ToString();
                frm.txtNombre.Text = dgvInventario.CurrentRow.Cells[2].Value.ToString();
                frm.txtDescripcion.Text = dgvInventario.CurrentRow.Cells[3].Value.ToString();
                frm.cbCategoria.Text = dgvInventario.CurrentRow.Cells[4].Value.ToString();
                frm.numStock.Text = dgvInventario.CurrentRow.Cells[5].Value.ToString();
                frm.txtPreCompra.Text = dgvInventario.CurrentRow.Cells[6].Value.ToString();
                frm.txtPrecVenta.Text = dgvInventario.CurrentRow.Cells[7].Value.ToString();
                frm.chbEstado.Checked = (bool)dgvInventario.CurrentRow.Cells[8].Value;
                frm.dtProducto.Text = dgvInventario.CurrentRow.Cells[9].Value.ToString();
                frm.ShowDialog();
                MostrarProdctos();



            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                IdProducto = dgvInventario.CurrentRow.Cells["IdProducto"].Value.ToString();
                objetoCN.EliminarPRod(IdProducto);
                MessageBox.Show("Eliminado correctamente");
                MostrarProdctos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
