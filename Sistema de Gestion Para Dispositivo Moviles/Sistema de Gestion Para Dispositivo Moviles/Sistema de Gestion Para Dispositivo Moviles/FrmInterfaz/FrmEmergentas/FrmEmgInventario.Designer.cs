namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    partial class FrmEmgInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmgInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerraEmgInv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPreCompra = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.cbPreVenta = new System.Windows.Forms.ComboBox();
            this.dtProducto = new System.Windows.Forms.DateTimePicker();
            this.chbEstado = new System.Windows.Forms.CheckBox();
            this.txtPrecVenta = new System.Windows.Forms.TextBox();
            this.txtPorciento = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCerraEmgInv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 40);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCerraEmgInv
            // 
            this.btnCerraEmgInv.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCerraEmgInv.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerraEmgInv.FlatAppearance.BorderSize = 0;
            this.btnCerraEmgInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCerraEmgInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerraEmgInv.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerraEmgInv.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnCerraEmgInv.Image = ((System.Drawing.Image)(resources.GetObject("btnCerraEmgInv.Image")));
            this.btnCerraEmgInv.Location = new System.Drawing.Point(373, 0);
            this.btnCerraEmgInv.Name = "btnCerraEmgInv";
            this.btnCerraEmgInv.Size = new System.Drawing.Size(40, 40);
            this.btnCerraEmgInv.TabIndex = 3;
            this.btnCerraEmgInv.UseVisualStyleBackColor = false;
            this.btnCerraEmgInv.Click += new System.EventHandler(this.btnCerraEmgInv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Precio Compra:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(191, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(194, 73);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(210, 142);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 73);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(149, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(268, 361);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(40, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(330, 361);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(40, 40);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtPreCompra
            // 
            this.txtPreCompra.Location = new System.Drawing.Point(12, 202);
            this.txtPreCompra.Name = "txtPreCompra";
            this.txtPreCompra.Size = new System.Drawing.Size(149, 20);
            this.txtPreCompra.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(12, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(149, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(338, 248);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(63, 20);
            this.numStock.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(335, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Stock";
            // 
            // cbCategoria
            // 
            this.cbCategoria.AutoCompleteCustomSource.AddRange(new string[] {
            "Movil",
            "Laptop",
            "Escritorio"});
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbCategoria.Location = new System.Drawing.Point(12, 156);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(149, 21);
            this.cbCategoria.TabIndex = 8;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // cbPreVenta
            // 
            this.cbPreVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbPreVenta.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPreVenta.FormattingEnabled = true;
            this.cbPreVenta.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90",
            "100"});
            this.cbPreVenta.Location = new System.Drawing.Point(240, 247);
            this.cbPreVenta.Name = "cbPreVenta";
            this.cbPreVenta.Size = new System.Drawing.Size(40, 21);
            this.cbPreVenta.TabIndex = 9;
            this.cbPreVenta.Text = "%";
            this.cbPreVenta.SelectedIndexChanged += new System.EventHandler(this.cbPreVenta_SelectedIndexChanged);
            // 
            // dtProducto
            // 
            this.dtProducto.Location = new System.Drawing.Point(204, 283);
            this.dtProducto.MaxDate = new System.DateTime(2022, 3, 7, 0, 0, 0, 0);
            this.dtProducto.Name = "dtProducto";
            this.dtProducto.Size = new System.Drawing.Size(200, 20);
            this.dtProducto.TabIndex = 10;
            this.dtProducto.Value = new System.DateTime(2022, 3, 7, 0, 0, 0, 0);
            this.dtProducto.ValueChanged += new System.EventHandler(this.dtProducto_ValueChanged);
            // 
            // chbEstado
            // 
            this.chbEstado.AutoSize = true;
            this.chbEstado.Location = new System.Drawing.Point(11, 283);
            this.chbEstado.Name = "chbEstado";
            this.chbEstado.Size = new System.Drawing.Size(59, 17);
            this.chbEstado.TabIndex = 11;
            this.chbEstado.Text = "Estado";
            this.chbEstado.ThreeState = true;
            this.chbEstado.UseVisualStyleBackColor = true;
            // 
            // txtPrecVenta
            // 
            this.txtPrecVenta.Location = new System.Drawing.Point(11, 248);
            this.txtPrecVenta.Name = "txtPrecVenta";
            this.txtPrecVenta.Size = new System.Drawing.Size(150, 20);
            this.txtPrecVenta.TabIndex = 12;
            this.txtPrecVenta.TextChanged += new System.EventHandler(this.txtPrecVenta_TextChanged);
            // 
            // txtPorciento
            // 
            this.txtPorciento.Location = new System.Drawing.Point(183, 248);
            this.txtPorciento.Name = "txtPorciento";
            this.txtPorciento.Size = new System.Drawing.Size(56, 20);
            this.txtPorciento.TabIndex = 13;
            this.txtPorciento.Text = "0";
            this.txtPorciento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorciento.TextChanged += new System.EventHandler(this.txtPorciento_TextChanged);
            // 
            // FrmEmgInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 413);
            this.Controls.Add(this.txtPorciento);
            this.Controls.Add(this.txtPrecVenta);
            this.Controls.Add(this.chbEstado);
            this.Controls.Add(this.dtProducto);
            this.Controls.Add(this.cbPreVenta);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtPreCompra);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmgInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEmgInventario";
            this.Load += new System.EventHandler(this.FrmEmgInventario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerraEmgInv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtPreCompra;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox cbCategoria;
        public System.Windows.Forms.NumericUpDown numStock;
        public System.Windows.Forms.ComboBox cbPreVenta;
        public System.Windows.Forms.DateTimePicker dtProducto;
        public System.Windows.Forms.CheckBox chbEstado;
        public System.Windows.Forms.TextBox txtPrecVenta;
        private System.Windows.Forms.TextBox txtPorciento;
    }
}