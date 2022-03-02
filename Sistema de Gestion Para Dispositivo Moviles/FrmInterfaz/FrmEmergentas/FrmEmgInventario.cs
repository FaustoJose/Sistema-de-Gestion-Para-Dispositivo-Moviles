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
         
        CN_Inventario objetoCN = new CN_Inventario();
       

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
                    objetoCN.InsertarPRod(txtCodigo.Text, txtCategoria.Text, txtMarca.Text, txtModelo.Text, txtClasificacion.Text, txtSubclasificacion.Text, txtCaracteristicas.Text, txtProvedor.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("Se Guardo Correctamente");
                    
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
                    objetoCN.EditarProd(txtCodigo.Text, txtCategoria.Text, txtMarca.Text, txtModelo.Text, txtClasificacion.Text, txtSubclasificacion.Text, txtCaracteristicas.Text, txtProvedor.Text, txtPrecio.Text, txtStock.Text);
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
            txtCategoria.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtClasificacion.Clear();
            txtSubclasificacion.Clear();
            txtCaracteristicas.Clear();
            txtProvedor.Clear();
            txtPrecio.Clear();
            txtStock.Clear();

        }
    }
}
