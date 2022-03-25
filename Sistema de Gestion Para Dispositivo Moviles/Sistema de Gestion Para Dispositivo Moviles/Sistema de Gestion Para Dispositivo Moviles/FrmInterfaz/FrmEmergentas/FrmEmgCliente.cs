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

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz
{
    public partial class FrmEmgCliente : Form
    {

        CN_Clientes objetoCN = new CN_Clientes();

        public string IdCliente = null;

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
        public FrmEmgCliente()
        {
            InitializeComponent();
        }

        private void FrmEmgCliente_Load(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            txtFecha.Text = fecha.ToString();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (getEditar() == false)
            {
                try
                {
                    objetoCN.InsertarCliente(txtDocumento.Text, txtNombre.Text, txtCorreo.Text, txtTelefono.Text, cbCategoria.Text, cbDescuento.Text, chbEstado.Checked.ToString(),txtFecha.Text);
                    MessageBox.Show("Se Guardo Correctamente");

                    limpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (getEditar() == true)
            {
                try
                {
                    objetoCN.EditarCliente(IdCliente,txtDocumento.Text, txtNombre.Text, txtCorreo.Text, txtTelefono.Text, cbCategoria.Text, cbDescuento.Text, chbEstado.Checked.ToString(), txtFecha.Text);
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


        



        private void limpiarForm()
        {
            txtDocumento.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            cbCategoria.Text = "";
            cbDescuento.Text = "";
            chbEstado.Checked = false;
           

        }

        private void btnCerraEmgInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
