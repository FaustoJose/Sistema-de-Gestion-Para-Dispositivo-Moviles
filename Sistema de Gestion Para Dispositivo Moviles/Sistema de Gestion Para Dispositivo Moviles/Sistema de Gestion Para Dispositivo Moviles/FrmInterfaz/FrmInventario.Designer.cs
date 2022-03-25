namespace Sistema_de_Gestion_Para_Dispositivo_Moviles
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.btnAgregarPro = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnCerraInv = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panelTitulo.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarPro
            // 
            this.btnAgregarPro.BackColor = System.Drawing.Color.White;
            this.btnAgregarPro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarPro.FlatAppearance.BorderSize = 0;
            this.btnAgregarPro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnAgregarPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarPro.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPro.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnAgregarPro.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarPro.Image")));
            this.btnAgregarPro.Location = new System.Drawing.Point(-1, 3);
            this.btnAgregarPro.Name = "btnAgregarPro";
            this.btnAgregarPro.Size = new System.Drawing.Size(60, 40);
            this.btnAgregarPro.TabIndex = 2;
            this.btnAgregarPro.UseVisualStyleBackColor = false;
            this.btnAgregarPro.Click += new System.EventHandler(this.btnAgregarPro_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.White;
            this.panelTitulo.Controls.Add(this.label1);
            this.panelTitulo.Controls.Add(this.button2);
            this.panelTitulo.Controls.Add(this.button1);
            this.panelTitulo.Controls.Add(this.textBox1);
            this.panelTitulo.Controls.Add(this.comboBox1);
            this.panelTitulo.Controls.Add(this.btnCerraInv);
            this.panelTitulo.Controls.Add(this.panel3);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(867, 46);
            this.panelTitulo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Buscar Por:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(694, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(341, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // btnCerraInv
            // 
            this.btnCerraInv.BackColor = System.Drawing.Color.Transparent;
            this.btnCerraInv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerraInv.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerraInv.FlatAppearance.BorderSize = 0;
            this.btnCerraInv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnCerraInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerraInv.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerraInv.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnCerraInv.Image = ((System.Drawing.Image)(resources.GetObject("btnCerraInv.Image")));
            this.btnCerraInv.Location = new System.Drawing.Point(827, 0);
            this.btnCerraInv.Name = "btnCerraInv";
            this.btnCerraInv.Size = new System.Drawing.Size(40, 46);
            this.btnCerraInv.TabIndex = 7;
            this.btnCerraInv.UseVisualStyleBackColor = false;
            this.btnCerraInv.Click += new System.EventHandler(this.btnCerraInv_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnEliminar);
            this.panel3.Controls.Add(this.btnAgregarPro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 46);
            this.panel3.TabIndex = 6;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(59, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(60, 40);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.PowderBlue;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(120, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(60, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventario.Location = new System.Drawing.Point(0, 46);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.ShowEditingIcon = false;
            this.dgvInventario.Size = new System.Drawing.Size(867, 440);
            this.dgvInventario.TabIndex = 6;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 486);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarPro;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerraInv;
        public System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}