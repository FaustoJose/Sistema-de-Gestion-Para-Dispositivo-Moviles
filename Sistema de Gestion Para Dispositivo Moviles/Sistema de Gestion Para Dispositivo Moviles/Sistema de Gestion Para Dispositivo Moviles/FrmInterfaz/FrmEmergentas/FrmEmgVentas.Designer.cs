namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    partial class FrmEmgVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmgVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerraEmgInv = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCodProducto = new System.Windows.Forms.TextBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.txtMontoCambio = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCrearVenta = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 495);
            this.label1.TabIndex = 0;
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
            this.btnCerraEmgInv.Location = new System.Drawing.Point(760, 0);
            this.btnCerraEmgInv.Name = "btnCerraEmgInv";
            this.btnCerraEmgInv.Size = new System.Drawing.Size(40, 40);
            this.btnCerraEmgInv.TabIndex = 3;
            this.btnCerraEmgInv.UseVisualStyleBackColor = false;
            this.btnCerraEmgInv.Click += new System.EventHandler(this.btnCerraEmgInv_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCerraEmgInv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 40);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrar Venta";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.txtDocumentoCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(437, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 78);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informacion Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(146, 39);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(36, 23);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(188, 41);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(161, 20);
            this.txtNombreCliente.TabIndex = 0;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(6, 41);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(134, 20);
            this.txtDocumentoCliente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre Completo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero Documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbTipoDocumento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFechaVenta);
            this.groupBox1.Location = new System.Drawing.Point(14, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Venta";
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.AutoCompleteCustomSource.AddRange(new string[] {
            "Factura",
            "Comprovante"});
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "Factura",
            "Comprovante"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(170, 41);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(162, 21);
            this.cbTipoDocumento.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tipo Documento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha:";
            // 
            // txtFechaVenta
            // 
            this.txtFechaVenta.Location = new System.Drawing.Point(33, 42);
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Size = new System.Drawing.Size(121, 20);
            this.txtFechaVenta.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtidproducto);
            this.groupBox3.Controls.Add(this.numCantidad);
            this.groupBox3.Controls.Add(this.btnBuscarProducto);
            this.groupBox3.Controls.Add(this.txtStock);
            this.groupBox3.Controls.Add(this.txtPrecio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtProducto);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCodProducto);
            this.groupBox3.Location = new System.Drawing.Point(14, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 100);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion de Producto";
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(118, 35);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(34, 20);
            this.txtidproducto.TabIndex = 4;
            this.txtidproducto.Visible = false;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(515, 60);
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(64, 20);
            this.numCantidad.TabIndex = 3;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(160, 58);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(36, 23);
            this.btnBuscarProducto.TabIndex = 2;
            this.btnBuscarProducto.Text = "...";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(442, 60);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(66, 20);
            this.txtStock.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(370, 60);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(66, 20);
            this.txtPrecio.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Stock:";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(203, 60);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(161, 20);
            this.txtProducto.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cod. Producto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Producto:";
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.Location = new System.Drawing.Point(32, 60);
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(121, 20);
            this.txtCodProducto.TabIndex = 0;
            // 
            // dgvdata
            // 
            this.dgvdata.AllowUserToAddRows = false;
            this.dgvdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvdata.BackgroundColor = System.Drawing.Color.White;
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Nombre,
            this.PrecioVenta,
            this.Cantida,
            this.subTotal});
            this.dgvdata.Location = new System.Drawing.Point(14, 258);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(625, 225);
            this.dgvdata.TabIndex = 12;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Producto";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // Cantida
            // 
            this.Cantida.HeaderText = "Cantidad";
            this.Cantida.Name = "Cantida";
            this.Cantida.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "SubTotal";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(645, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Pagar con:";
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(646, 338);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(146, 20);
            this.txtMontoPago.TabIndex = 13;
            this.txtMontoPago.TextChanged += new System.EventHandler(this.txtMontoPago_TextChanged);
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Location = new System.Drawing.Point(647, 389);
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Size = new System.Drawing.Size(145, 20);
            this.txtMontoCambio.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(645, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Cambio:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(645, 145);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 94);
            this.btnAgregar.TabIndex = 19;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCrearVenta
            // 
            this.btnCrearVenta.Location = new System.Drawing.Point(646, 420);
            this.btnCrearVenta.Name = "btnCrearVenta";
            this.btnCrearVenta.Size = new System.Drawing.Size(146, 53);
            this.btnCrearVenta.TabIndex = 20;
            this.btnCrearVenta.Text = "Crear Venta";
            this.btnCrearVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearVenta.UseVisualStyleBackColor = true;
            this.btnCrearVenta.Click += new System.EventHandler(this.btnCrearVenta_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(644, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total a Pagar:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(646, 276);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(146, 20);
            this.txtMontoTotal.TabIndex = 15;
            // 
            // FrmEmgVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.txtMontoCambio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCrearVenta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEmgVentas";
            this.Text = "FrmEmgVentas";
            this.Load += new System.EventHandler(this.FrmEmgVentas_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerraEmgInv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarCliente;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFechaVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnBuscarProducto;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtCodProducto;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.TextBox txtMontoCambio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCrearVenta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMontoTotal;
    }
}