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
using Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    public partial class FrmEmgListaProductos : Form
    {
        public FrmEmgListaProductos()
        {
            InitializeComponent();
        }


        private void FrmEmgListaProductos_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }
        private void MostrarProdctos()
        {
            CN_Inventario objeto = new CN_Inventario();
            dgvEmgProducto.DataSource = objeto.MostrarProd();
        }

        private void txtBuscarProducto_TextChanged_1(object sender, EventArgs e)
        {
            CN_Ventas objProducto = new CN_Ventas();
            dgvEmgProducto.DataSource = objProducto.MostrarProducto(txtBuscarProducto.Text);

        }

        private void dgvEmgProducto_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FrmEmgVentas fm = Owner as FrmEmgVentas;

            if (dgvEmgProducto.SelectedRows.Count > 0)
            {

                fm.txtidproducto.Text = dgvEmgProducto.CurrentRow.Cells[0].Value.ToString();
                fm.txtCodProducto.Text = dgvEmgProducto.CurrentRow.Cells[1].Value.ToString();
                fm.txtProducto.Text = dgvEmgProducto.CurrentRow.Cells[2].Value.ToString();
                fm.txtStock.Text = dgvEmgProducto.CurrentRow.Cells[5].Value.ToString();
                fm.txtPrecio.Text = dgvEmgProducto.CurrentRow.Cells[7].Value.ToString();

                this.Close();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }
    }
}
