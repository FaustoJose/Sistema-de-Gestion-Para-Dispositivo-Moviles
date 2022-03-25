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

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    public partial class FrmEmgListaCliente : Form
    {
        public FrmEmgListaCliente()
        {
            InitializeComponent();
        }


        private void MostrarProdctos()
        {
            CN_Clientes objeto = new CN_Clientes();
            dgvMostrarCliente.DataSource = objeto.MostrarCliente();
        }

        private void FrmEmgListaCliente_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void dgvMostrarCliente_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FrmEmgVentas fm = Owner as FrmEmgVentas;

            if (dgvMostrarCliente.SelectedRows.Count > 0)
            {

                fm.txtDocumentoCliente.Text = dgvMostrarCliente.CurrentRow.Cells[1].Value.ToString();
                fm.txtNombreCliente.Text = dgvMostrarCliente.CurrentRow.Cells[2].Value.ToString();


                this.Close();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");

        }
    }
}
