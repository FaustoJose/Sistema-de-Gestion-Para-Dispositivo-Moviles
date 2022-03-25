using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Clases;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    public partial class FrmEmgVentas : Form
    {
        public FrmEmgVentas()
        {
            InitializeComponent();
        }

        private void FrmEmgVentas_Load(object sender, EventArgs e)
        {
            txtidproducto.Text = "0";
            numCantidad.Value = 1;
            DateTime time = DateTime.Now;
            txtFechaVenta.Text = time.ToShortDateString().ToString();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmEmgListaCliente());
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmEmgListaProductos());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            decimal precio = 0;


            if (int.Parse(txtidproducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("precio - Formato moneda incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }

            if (Convert.ToInt32(txtStock.Text) < Convert.ToInt32(numCantidad.Value.ToString()))
            {
                MessageBox.Show("Debe seleccionar un producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (int n = 0; n <= dgvdata.Rows.Count - 1; n++)
            {

                DataGridViewRow row = dgvdata.Rows[n];
                if (row.Cells["IdProducto"].Value.ToString() == txtidproducto.Text)
                {
                    MessageBox.Show("Ese Producto ya esta en la lista", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

            }

            string montototal;
            double precios = 0, cantidad = 0, SubTotal = 0, MontoTotal = 0, i = 0;
            precios = Convert.ToDouble(txtPrecio.Text);
            cantidad = Convert.ToDouble(numCantidad.Text);
            SubTotal = precios * cantidad;


            dgvdata.Rows.Add(new object[] {
                txtidproducto.Text,
                txtProducto.Text,
                txtPrecio.Text,
                numCantidad.Text,
                SubTotal.ToString("0.00")
                });

            txtidproducto.Text = "0";
            txtProducto.Text = "";
            txtPrecio.Text = "";
            numCantidad.Value = 1;
            txtCodProducto.Text = "0";


            for (int n = 0; n <= dgvdata.Rows.Count - 1; n++)
            {


                DataGridViewRow row = dgvdata.Rows[n];
                montototal = row.Cells["subTotal"].Value.ToString();
                i = Convert.ToDouble(montototal);
                i = i + MontoTotal;
                MontoTotal = i;

                txtMontoTotal.Text = MontoTotal.ToString("0.00");
            }

        }

        private void txtMontoPago_TextChanged(object sender, EventArgs e)
        {
            double cambio = 0, montopago = 0, montototal = 0, cam = 0;

            if (txtMontoPago.Text == "")
            {
                txtMontoPago.Text = montopago.ToString(".00");
            }


            montopago = Convert.ToDouble(txtMontoPago.Text);
            montototal = Convert.ToDouble(txtMontoTotal.Text);
            cambio = montopago - montototal;
            txtMontoCambio.Text = cambio.ToString("0.00");
        }

        private void btnCrearVenta_Click(object sender, EventArgs e)
        {
            try
            {
                List<Detalle_Venta> lst = new List<Detalle_Venta>();

                //llenado de elementos detalles
                foreach (DataGridViewRow dr in dgvdata.Rows)
                {
                    Detalle_Venta oDetalle_Venta = new Detalle_Venta();
                    oDetalle_Venta.IdProducto = int.Parse(dr.Cells[0].Value.ToString());
                    oDetalle_Venta.Precioventa = Convert.ToDouble(dr.Cells[2].Value.ToString());
                    oDetalle_Venta.Cantidad = int.Parse(dr.Cells[3].Value.ToString());
                    oDetalle_Venta.SubTotal = Convert.ToDouble(dr.Cells[4].Value.ToString());
                    lst.Add(oDetalle_Venta);
                }

                CD_Ventas objetocd = new CD_Ventas();

                objetocd.Insertar(int.Parse("1"), cbTipoDocumento.Text, txtDocumentoCliente.Text, txtNombreCliente.Text, Convert.ToDouble(txtMontoPago.Text), Convert.ToDouble(txtMontoCambio.Text), Convert.ToDouble(txtMontoTotal.Text), lst);
                MessageBox.Show("Se Guardo Correctamente");

                //Borrado de dgvdata
                
                dgvdata.Rows.Clear();

                //linpiado formulario

                limpiarForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar los datos por: " + ex);
            }

        }

        private void AbrirFormInPanel(object Formhijo)
        {

            Form fh = Formhijo as Form;
            AddOwnedForm(fh);
            fh.ShowDialog();

        }

        private void limpiarForm()
        {
            cbTipoDocumento.Text = "";
            txtDocumentoCliente.Text = "";
            txtNombreCliente.Text = "";
            txtMontoPago.Text = "";
            txtMontoCambio.Text = "";
            txtMontoTotal.Text = "";
            txtStock.Text = "0";
        }

        private void btnCerraEmgInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
