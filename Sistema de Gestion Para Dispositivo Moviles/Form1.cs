using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz;

namespace Sistema_de_Gestion_Para_Dispositivo_Moviles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wnsg, int wparam, int lparam);


        private void btnslide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 58;
            }
            else {
                MenuVertical.Width = 250;
            }
        }

       

        private void iconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconNormalizar.Visible = true;
            iconMaximizar.Visible = false;
        }

        private void iconNormalizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconNormalizar.Visible = false;
            iconMaximizar.Visible = true;
        }

        private void iconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AbrirFormInPanel(object Formhijo) 
        {
            if (this.panelContenedor.Controls.Count>0)
            this.panelContenedor.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        private void btnInventario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmInventario());
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmSevicio());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmVentas());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmCliente());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new FrmElc());
        }
    }
}
