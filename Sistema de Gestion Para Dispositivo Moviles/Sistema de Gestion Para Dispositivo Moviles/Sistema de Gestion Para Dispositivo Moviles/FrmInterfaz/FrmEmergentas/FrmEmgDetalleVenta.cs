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
    public partial class FrmEmgDetalleVenta : Form
    {
        CN_Detalle_Venta objectCN = new CN_Detalle_Venta();

        public string IdVentas;

        public FrmEmgDetalleVenta()
        {
            InitializeComponent();
        }


        private void FrmEmgDetalleVenta_Load(object sender, EventArgs e)
        {
            MostrarDetalle();
        }
        private void MostrarDetalle()
        {
            CN_Detalle_Venta objectCN = new CN_Detalle_Venta();
            dgvDataDetalle.DataSource = objectCN.MostrarVenta(IdVentas);
        }

        

        private void btnCerraEmgInv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        
    }
}
