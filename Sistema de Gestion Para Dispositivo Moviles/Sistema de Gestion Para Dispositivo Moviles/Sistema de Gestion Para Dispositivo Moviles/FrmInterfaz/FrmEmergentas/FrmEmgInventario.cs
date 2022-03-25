using Sistema_de_Gestion_Para_Dispositivo_Moviles.Conexcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    public partial class FrmEmgInventario : Form
    {

        public string IdProducto = null;

        CN_Inventario objetoCN = new CN_Inventario();
        FrmInventario fm = new FrmInventario();
       

        private bool Editar = false;

        public void setEditar(bool editar)
        {
            this.Editar = editar;
        }

        public bool getEditar()
        {
            return this.Editar;
        }
        public void EditarTrue()
        {
            setEditar(true);

        }
        public void EditarFalse()
        {
            setEditar(false);

        }

        private void MostrarProdctos()
        {
            CN_Inventario objeto = new CN_Inventario();
            fm.dgvInventario.DataSource = objeto.MostrarProd();
        }
        public FrmEmgInventario()
        {
            InitializeComponent();
        }

        private void FrmEmgInventario_Load(object sender, EventArgs e)
        {

        }
       


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            //INSERTAR
            if(getEditar()==false)
            {
                try
                {
                    objetoCN.InsertarPRod(txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, cbCategoria.Text, numStock.Text, txtPreCompra.Text, txtPrecVenta.Text, chbEstado.Checked.ToString(), dtProducto.Text);
                    MessageBox.Show("Se Guardo Correctamente");
                    MostrarProdctos();
                    limpiarForm();
                    


                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (getEditar()==true)
            {
                try
                {   
                    objetoCN.EditarProd(IdProducto, txtCodigo.Text, txtNombre.Text, txtDescripcion.Text, cbCategoria.Text, numStock.Text, txtPreCompra.Text, txtPrecVenta.Text, chbEstado.Checked.ToString(), dtProducto.Text);
                    MessageBox.Show("Se edito correctamente");
                    
                    //limpiarForm();
                    EditarFalse();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnCerraEmgInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void limpiarForm()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtPreCompra.Clear();
            cbCategoria.Text="";
            numStock.Text="";
            txtPreCompra.Text="";
            cbPreVenta.Text="";
            chbEstado.Checked=false;
            dtProducto.Text="";

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.Text == "Movil")
            {
                cbCategoria.Text = "1";
            }else if (cbCategoria.Text == "Laptop")
            {
                cbCategoria.Text = "2";
            }
            else if (cbCategoria.Text == "Escritorio")
            {
                cbCategoria.Text = "3";
            }
        }

        private double SumarPorciento(double precioCompra=0,int porcentaje=0)
        {
            double valor;
           
                valor = precioCompra + precioCompra * porcentaje / 100;

                return valor;
        }

        private void cbPreVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrecVenta.Text = "0";
            txtPrecVenta.Text=SumarPorciento(Convert.ToDouble(txtPreCompra.Text),Convert.ToInt32(cbPreVenta.SelectedItem.ToString())).ToString();




            
        }

        private void dtProducto_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha=DateTime.Today;
            dtProducto.Value = fecha;
        }

        private void txtPorciento_TextChanged(object sender, EventArgs e)
        {
            
            if (txtPorciento.Text == "")
            {
                cbPreVenta.Text = "%";
                txtPorciento.Text = "0";
                txtPrecVenta.Text = SumarPorciento(Convert.ToDouble(txtPreCompra.Text), Convert.ToInt32(txtPorciento.Text)).ToString();

            }
            else
            {
                cbPreVenta.Text = "%";
                txtPrecVenta.Text = SumarPorciento(Convert.ToDouble(txtPreCompra.Text), Convert.ToInt32(txtPorciento.Text)).ToString();
            }

           
        }

        private void txtPrecVenta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
