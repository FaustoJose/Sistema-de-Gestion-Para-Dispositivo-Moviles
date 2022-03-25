namespace Sistema_de_Gestion_Para_Dispositivo_Moviles.FrmInterfaz.FrmEmergentas
{
    partial class FrmEmgListaProductos
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEmgProducto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(740, 84);
            this.label2.TabIndex = 5;
            this.label2.Tag = "";
            this.label2.Text = "Lista de Productos:";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(331, 44);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(139, 20);
            this.txtBuscarProducto.TabIndex = 6;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged_1);
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Location = new System.Drawing.Point(194, 43);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(121, 21);
            this.cmbSeleccion.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(126, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Buscar Por:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(521, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 210);
            this.label3.TabIndex = 10;
            // 
            // dgvEmgProducto
            // 
            this.dgvEmgProducto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvEmgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmgProducto.Location = new System.Drawing.Point(4, 103);
            this.dgvEmgProducto.Name = "dgvEmgProducto";
            this.dgvEmgProducto.Size = new System.Drawing.Size(582, 219);
            this.dgvEmgProducto.TabIndex = 11;
            this.dgvEmgProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmgProducto_CellDoubleClick_1);
            // 
            // FrmEmgListaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 324);
            this.Controls.Add(this.dgvEmgProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSeleccion);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmEmgListaProductos";
            this.Text = "FrmEmgListaProductos";
            this.Load += new System.EventHandler(this.FrmEmgListaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmgProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.ComboBox cmbSeleccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEmgProducto;
    }
}