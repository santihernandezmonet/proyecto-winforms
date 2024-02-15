namespace winform_app
{
    partial class frmDetalleArticulo
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
            this.pboxDetalle = new System.Windows.Forms.PictureBox();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.txtBoxDetalleNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDetalleMarca = new System.Windows.Forms.TextBox();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.txtBoxDetalleCategoria = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtBoxDetallePrecio = new System.Windows.Forms.TextBox();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.txtBoxDetalleDescrip = new System.Windows.Forms.TextBox();
            this.lblDetalleDescrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxDetalle
            // 
            this.pboxDetalle.Location = new System.Drawing.Point(113, 56);
            this.pboxDetalle.Name = "pboxDetalle";
            this.pboxDetalle.Size = new System.Drawing.Size(311, 253);
            this.pboxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxDetalle.TabIndex = 0;
            this.pboxDetalle.TabStop = false;
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleNombre.ForeColor = System.Drawing.Color.White;
            this.lblDetalleNombre.Location = new System.Drawing.Point(449, 60);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(54, 13);
            this.lblDetalleNombre.TabIndex = 1;
            this.lblDetalleNombre.Text = "Nombre:";
            // 
            // txtBoxDetalleNombre
            // 
            this.txtBoxDetalleNombre.Location = new System.Drawing.Point(511, 57);
            this.txtBoxDetalleNombre.Name = "txtBoxDetalleNombre";
            this.txtBoxDetalleNombre.Size = new System.Drawing.Size(154, 20);
            this.txtBoxDetalleNombre.TabIndex = 2;
            // 
            // txtBoxDetalleMarca
            // 
            this.txtBoxDetalleMarca.Location = new System.Drawing.Point(511, 96);
            this.txtBoxDetalleMarca.Name = "txtBoxDetalleMarca";
            this.txtBoxDetalleMarca.Size = new System.Drawing.Size(154, 20);
            this.txtBoxDetalleMarca.TabIndex = 4;
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleMarca.ForeColor = System.Drawing.Color.White;
            this.lblDetalleMarca.Location = new System.Drawing.Point(449, 99);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(46, 13);
            this.lblDetalleMarca.TabIndex = 3;
            this.lblDetalleMarca.Text = "Marca:";
            // 
            // txtBoxDetalleCategoria
            // 
            this.txtBoxDetalleCategoria.Location = new System.Drawing.Point(511, 138);
            this.txtBoxDetalleCategoria.Name = "txtBoxDetalleCategoria";
            this.txtBoxDetalleCategoria.Size = new System.Drawing.Size(154, 20);
            this.txtBoxDetalleCategoria.TabIndex = 6;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.White;
            this.lblCategoria.Location = new System.Drawing.Point(439, 141);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblCategoria.TabIndex = 5;
            this.lblCategoria.Text = "Categoría:";
            // 
            // txtBoxDetallePrecio
            // 
            this.txtBoxDetallePrecio.Location = new System.Drawing.Point(511, 175);
            this.txtBoxDetallePrecio.Name = "txtBoxDetallePrecio";
            this.txtBoxDetallePrecio.Size = new System.Drawing.Size(154, 20);
            this.txtBoxDetallePrecio.TabIndex = 8;
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePrecio.ForeColor = System.Drawing.Color.White;
            this.lblDetallePrecio.Location = new System.Drawing.Point(449, 178);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(47, 13);
            this.lblDetallePrecio.TabIndex = 7;
            this.lblDetallePrecio.Text = "Precio:";
            // 
            // txtBoxDetalleDescrip
            // 
            this.txtBoxDetalleDescrip.Location = new System.Drawing.Point(523, 217);
            this.txtBoxDetalleDescrip.Multiline = true;
            this.txtBoxDetalleDescrip.Name = "txtBoxDetalleDescrip";
            this.txtBoxDetalleDescrip.Size = new System.Drawing.Size(204, 92);
            this.txtBoxDetalleDescrip.TabIndex = 10;
            // 
            // lblDetalleDescrip
            // 
            this.lblDetalleDescrip.AutoSize = true;
            this.lblDetalleDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleDescrip.ForeColor = System.Drawing.Color.White;
            this.lblDetalleDescrip.Location = new System.Drawing.Point(439, 220);
            this.lblDetalleDescrip.Name = "lblDetalleDescrip";
            this.lblDetalleDescrip.Size = new System.Drawing.Size(78, 13);
            this.lblDetalleDescrip.TabIndex = 9;
            this.lblDetalleDescrip.Text = "Descripción:";
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(170)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDetalleDescrip);
            this.Controls.Add(this.lblDetalleDescrip);
            this.Controls.Add(this.txtBoxDetallePrecio);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.txtBoxDetalleCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.txtBoxDetalleMarca);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.txtBoxDetalleNombre);
            this.Controls.Add(this.lblDetalleNombre);
            this.Controls.Add(this.pboxDetalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetalleArticulo";
            this.Text = "Detalle del Articulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pboxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxDetalle;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.TextBox txtBoxDetalleNombre;
        private System.Windows.Forms.TextBox txtBoxDetalleMarca;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.TextBox txtBoxDetalleCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtBoxDetallePrecio;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.TextBox txtBoxDetalleDescrip;
        private System.Windows.Forms.Label lblDetalleDescrip;
    }
}