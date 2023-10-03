namespace ProyectoTaller2
{
    partial class FormVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridVenta = new System.Windows.Forms.DataGridView();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarCarrito = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClienteVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridVenta
            // 
            this.dataGridVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreProd,
            this.marcaProd,
            this.stockProd,
            this.precioProd,
            this.descProd,
            this.categProd,
            this.eliminarCarrito});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridVenta.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridVenta.Location = new System.Drawing.Point(12, 98);
            this.dataGridVenta.Name = "dataGridVenta";
            this.dataGridVenta.ReadOnly = true;
            this.dataGridVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridVenta.Size = new System.Drawing.Size(764, 281);
            this.dataGridVenta.TabIndex = 0;
            this.dataGridVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVenta_CellClick);
            this.dataGridVenta.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridVenta_CellFormatting);
            this.dataGridVenta.SelectionChanged += new System.EventHandler(this.dataGridVenta_SelectionChanged);
            // 
            // nombreProd
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            this.nombreProd.DefaultCellStyle = dataGridViewCellStyle10;
            this.nombreProd.HeaderText = "Nombre";
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            // 
            // marcaProd
            // 
            this.marcaProd.HeaderText = "Marca";
            this.marcaProd.Name = "marcaProd";
            this.marcaProd.ReadOnly = true;
            // 
            // stockProd
            // 
            this.stockProd.HeaderText = "Stock";
            this.stockProd.Name = "stockProd";
            this.stockProd.ReadOnly = true;
            // 
            // precioProd
            // 
            this.precioProd.HeaderText = "Precio";
            this.precioProd.Name = "precioProd";
            this.precioProd.ReadOnly = true;
            // 
            // descProd
            // 
            this.descProd.HeaderText = "Descripcion";
            this.descProd.Name = "descProd";
            this.descProd.ReadOnly = true;
            // 
            // categProd
            // 
            this.categProd.HeaderText = "Categoria";
            this.categProd.Name = "categProd";
            this.categProd.ReadOnly = true;
            // 
            // eliminarCarrito
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.eliminarCarrito.DefaultCellStyle = dataGridViewCellStyle11;
            this.eliminarCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eliminarCarrito.HeaderText = "";
            this.eliminarCarrito.Name = "eliminarCarrito";
            this.eliminarCarrito.ReadOnly = true;
            this.eliminarCarrito.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminarCarrito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.eliminarCarrito.Text = "";
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRealizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarVenta.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnRealizarVenta.Location = new System.Drawing.Point(665, 32);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(111, 43);
            this.btnRealizarVenta.TabIndex = 1;
            this.btnRealizarVenta.Text = "Finalizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = false;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnCancelar.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelar.IconColor = System.Drawing.Color.Black;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(549, 31);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 44);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(487, 398);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(165, 24);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "TOTAL A PAGAR:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(675, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(16, 24);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cliente: ";
            // 
            // txtClienteVenta
            // 
            this.txtClienteVenta.Location = new System.Drawing.Point(87, 55);
            this.txtClienteVenta.Name = "txtClienteVenta";
            this.txtClienteVenta.ReadOnly = true;
            this.txtClienteVenta.Size = new System.Drawing.Size(133, 20);
            this.txtClienteVenta.TabIndex = 7;
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(786, 443);
            this.Controls.Add(this.txtClienteVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.dataGridVenta);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormVenta";
            this.Text = "FormVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridVenta;
        private System.Windows.Forms.Button btnRealizarVenta;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn categProd;
        private System.Windows.Forms.DataGridViewButtonColumn eliminarCarrito;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClienteVenta;
    }
}