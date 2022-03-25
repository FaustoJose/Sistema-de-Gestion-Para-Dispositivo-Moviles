using Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz
{
    public partial class FrmSevicio : Form
    {
        public FrmSevicio()
        {
            InitializeComponent();
        }

        private void FrmSevicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmgServicio frm = new FrmEmgServicio();
            frm.ShowDialog();
        }
    }
}
