namespace ProyectoTaller2.Capa_Presentacion.Administrador
{
    partial class FormVendedoresAdmin
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
            this.dataGridVendedores = new System.Windows.Forms.DataGridView();
            this.nombreVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioVendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerVentas = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVendedores
            // 
            this.dataGridVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreVendedor,
            this.apellidoVendedor,
            this.telefonoVendedor,
            this.usuarioVendedor});
            this.dataGridVendedores.Location = new System.Drawing.Point(4, 114);
            this.dataGridVendedores.Name = "dataGridVendedores";
            this.dataGridVendedores.ReadOnly = true;
            this.dataGridVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVendedores.Size = new System.Drawing.Size(772, 252);
            this.dataGridVendedores.TabIndex = 0;
            this.dataGridVendedores.SelectionChanged += new System.EventHandler(this.dataGridVendedores_SelectionChanged);
            // 
            // nombreVendedor
            // 
            this.nombreVendedor.HeaderText = "Nombre";
            this.nombreVendedor.Name = "nombreVendedor";
            this.nombreVendedor.ReadOnly = true;
            // 
            // apellidoVendedor
            // 
            this.apellidoVendedor.HeaderText = "Apellido";
            this.apellidoVendedor.Name = "apellidoVendedor";
            this.apellidoVendedor.ReadOnly = true;
            // 
            // telefonoVendedor
            // 
            this.telefonoVendedor.HeaderText = "Telefono";
            this.telefonoVendedor.Name = "telefonoVendedor";
            this.telefonoVendedor.ReadOnly = true;
            // 
            // usuarioVendedor
            // 
            this.usuarioVendedor.HeaderText = "Usuario";
            this.usuarioVendedor.Name = "usuarioVendedor";
            this.usuarioVendedor.ReadOnly = true;
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnVerVentas.IconColor = System.Drawing.Color.Black;
            this.btnVerVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerVentas.Location = new System.Drawing.Point(644, 25);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(110, 31);
            this.btnVerVentas.TabIndex = 1;
            this.btnVerVentas.Text = "Ver Ventas";
            this.btnVerVentas.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por nombre:";
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(169, 36);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(121, 20);
            this.txtNombreVendedor.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(296, 34);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(37, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // FormVendedoresAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(778, 368);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtNombreVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVerVentas);
            this.Controls.Add(this.dataGridVendedores);
            this.Name = "FormVendedoresAdmin";
            this.Text = "FormVendedoresAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoVendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioVendedor;
        private FontAwesome.Sharp.IconButton btnVerVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private FontAwesome.Sharp.IconButton btnBuscar;
    }
}