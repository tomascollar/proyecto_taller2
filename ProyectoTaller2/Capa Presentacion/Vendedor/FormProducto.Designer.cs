namespace ProyectoTaller2
{
    partial class FormProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarCarrito = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(319, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(140, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "BUSCAR PRODUCTO";
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Location = new System.Drawing.Point(356, 115);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(75, 33);
            this.btnBuscarProd.TabIndex = 4;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = true;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNombre,
            this.columnaMarca,
            this.columnaStock,
            this.columnaPrecio,
            this.columnaDescripcion,
            this.columnaCategoria});
            this.dataGridView1.Location = new System.Drawing.Point(3, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(765, 253);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // columnaNombre
            // 
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            // 
            // columnaMarca
            // 
            this.columnaMarca.HeaderText = "Marca";
            this.columnaMarca.Name = "columnaMarca";
            // 
            // columnaStock
            // 
            this.columnaStock.HeaderText = "Stock";
            this.columnaStock.Name = "columnaStock";
            // 
            // columnaPrecio
            // 
            this.columnaPrecio.HeaderText = "Precio";
            this.columnaPrecio.Name = "columnaPrecio";
            // 
            // columnaDescripcion
            // 
            this.columnaDescripcion.HeaderText = "Descripción";
            this.columnaDescripcion.Name = "columnaDescripcion";
            // 
            // columnaCategoria
            // 
            this.columnaCategoria.HeaderText = "Categoria";
            this.columnaCategoria.Name = "columnaCategoria";
            // 
            // btnAgregarCarrito
            // 
            this.btnAgregarCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCarrito.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnAgregarCarrito.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCarrito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCarrito.IconSize = 30;
            this.btnAgregarCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarCarrito.Location = new System.Drawing.Point(660, 105);
            this.btnAgregarCarrito.Name = "btnAgregarCarrito";
            this.btnAgregarCarrito.Size = new System.Drawing.Size(108, 43);
            this.btnAgregarCarrito.TabIndex = 6;
            this.btnAgregarCarrito.Text = "Agregar al carrito";
            this.btnAgregarCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarCarrito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarCarrito.UseVisualStyleBackColor = true;
            this.btnAgregarCarrito.Click += new System.EventHandler(this.btnAgregarCarrito_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(780, 430);
            this.Controls.Add(this.btnAgregarCarrito);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "FormProducto";
            this.Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaCategoria;
        private FontAwesome.Sharp.IconButton btnAgregarCarrito;
    }
}