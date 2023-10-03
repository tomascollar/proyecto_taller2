namespace ProyectoTaller2.Capa_Presentacion.SuperAdmin
{
    partial class Movimientos
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
            this.dataGridMovimientos = new System.Windows.Forms.DataGridView();
            this.btnListarVentas = new FontAwesome.Sharp.IconButton();
            this.btnListarCompras = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOVIMIENTOS";
            // 
            // dataGridMovimientos
            // 
            this.dataGridMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMovimientos.Location = new System.Drawing.Point(0, 159);
            this.dataGridMovimientos.Name = "dataGridMovimientos";
            this.dataGridMovimientos.Size = new System.Drawing.Size(800, 238);
            this.dataGridMovimientos.TabIndex = 1;
            // 
            // btnListarVentas
            // 
            this.btnListarVentas.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnListarVentas.IconColor = System.Drawing.Color.Black;
            this.btnListarVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarVentas.Location = new System.Drawing.Point(237, 94);
            this.btnListarVentas.Name = "btnListarVentas";
            this.btnListarVentas.Size = new System.Drawing.Size(88, 34);
            this.btnListarVentas.TabIndex = 2;
            this.btnListarVentas.Text = "Listar ventas";
            this.btnListarVentas.UseVisualStyleBackColor = true;
            // 
            // btnListarCompras
            // 
            this.btnListarCompras.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnListarCompras.IconColor = System.Drawing.Color.Black;
            this.btnListarCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListarCompras.Location = new System.Drawing.Point(434, 94);
            this.btnListarCompras.Name = "btnListarCompras";
            this.btnListarCompras.Size = new System.Drawing.Size(89, 34);
            this.btnListarCompras.TabIndex = 3;
            this.btnListarCompras.Text = "Listar compras";
            this.btnListarCompras.UseVisualStyleBackColor = true;
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarCompras);
            this.Controls.Add(this.btnListarVentas);
            this.Controls.Add(this.dataGridMovimientos);
            this.Controls.Add(this.label1);
            this.Name = "Movimientos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimientos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMovimientos;
        private FontAwesome.Sharp.IconButton btnListarVentas;
        private FontAwesome.Sharp.IconButton btnListarCompras;
    }
}