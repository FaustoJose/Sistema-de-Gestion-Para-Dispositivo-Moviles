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
    public partial class FrmEmgServicio : Form
    {


        private bool a=false;
        public FrmEmgServicio()
        {
            InitializeComponent();
        }
       

        private void Cambio(bool a)
        {
            try
            {


                if (chbComputadora.Checked == a)
                {
                    //chbCelular.Checked = !a;
                    lbPcCheck.Visible = a;
                    pnCelularCherk.Visible = !a;
                }
                else if (chbCelular.Checked == a)
                {
                    //chbComputadora.Checked = !a;
                    lbPcCheck.Visible = !a;
                    pnCelularCherk.Visible = a;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo por: " + ex);
            }
        }

        private void FrmEmgServicio_Load(object sender, EventArgs e)
        {
            chbCelular.Checked = true;
            pnCelularCherk.Visible = true;


        }

        

        private void chbCelular_Click_1(object sender, EventArgs e)
        {
            chbComputadora.Checked = false;

            a = chbCelular.Checked = true;
            Cambio(a);
        }

        private void chbComputadora_Click_1(object sender, EventArgs e)
        {
            chbCelular.Checked = false;

            a = chbComputadora.Checked = true;
            Cambio(a);
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }

}
