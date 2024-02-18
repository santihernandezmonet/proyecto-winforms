namespace winform_app
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconBtnAjustes = new FontAwesome.Sharp.IconButton();
            this.iconBtnAgregar = new FontAwesome.Sharp.IconButton();
            this.iconBtnListar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconBtnClose = new FontAwesome.Sharp.IconButton();
            this.iconBtnMaximize = new FontAwesome.Sharp.IconButton();
            this.iconBtnMinimize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(132)))));
            this.panelMenu.Controls.Add(this.iconBtnAjustes);
            this.panelMenu.Controls.Add(this.iconBtnAgregar);
            this.panelMenu.Controls.Add(this.iconBtnListar);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 676);
            this.panelMenu.TabIndex = 0;
            // 
            // iconBtnAjustes
            // 
            this.iconBtnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnAjustes.FlatAppearance.BorderSize = 0;
            this.iconBtnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAjustes.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAjustes.ForeColor = System.Drawing.Color.White;
            this.iconBtnAjustes.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconBtnAjustes.IconColor = System.Drawing.Color.White;
            this.iconBtnAjustes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAjustes.IconSize = 32;
            this.iconBtnAjustes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAjustes.Location = new System.Drawing.Point(0, 270);
            this.iconBtnAjustes.Name = "iconBtnAjustes";
            this.iconBtnAjustes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnAjustes.Size = new System.Drawing.Size(220, 65);
            this.iconBtnAjustes.TabIndex = 4;
            this.iconBtnAjustes.Text = "AJUSTES";
            this.iconBtnAjustes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAjustes.UseVisualStyleBackColor = true;
            this.iconBtnAjustes.Click += new System.EventHandler(this.iconBtnAjustes_Click);
            // 
            // iconBtnAgregar
            // 
            this.iconBtnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnAgregar.FlatAppearance.BorderSize = 0;
            this.iconBtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnAgregar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnAgregar.ForeColor = System.Drawing.Color.White;
            this.iconBtnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconBtnAgregar.IconColor = System.Drawing.Color.White;
            this.iconBtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnAgregar.IconSize = 32;
            this.iconBtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAgregar.Location = new System.Drawing.Point(0, 205);
            this.iconBtnAgregar.Name = "iconBtnAgregar";
            this.iconBtnAgregar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnAgregar.Size = new System.Drawing.Size(220, 65);
            this.iconBtnAgregar.TabIndex = 3;
            this.iconBtnAgregar.Text = "AGREGAR ARTICULO";
            this.iconBtnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnAgregar.UseVisualStyleBackColor = true;
            this.iconBtnAgregar.Click += new System.EventHandler(this.iconBtnAgregar_Click);
            // 
            // iconBtnListar
            // 
            this.iconBtnListar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnListar.FlatAppearance.BorderSize = 0;
            this.iconBtnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnListar.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnListar.ForeColor = System.Drawing.Color.White;
            this.iconBtnListar.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconBtnListar.IconColor = System.Drawing.Color.White;
            this.iconBtnListar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnListar.IconSize = 32;
            this.iconBtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnListar.Location = new System.Drawing.Point(0, 140);
            this.iconBtnListar.Name = "iconBtnListar";
            this.iconBtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnListar.Size = new System.Drawing.Size(220, 65);
            this.iconBtnListar.TabIndex = 2;
            this.iconBtnListar.Text = "LISTAR ARTICULOS";
            this.iconBtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnListar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnListar.UseVisualStyleBackColor = true;
            this.iconBtnListar.Click += new System.EventHandler(this.iconBtnListar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(220, 140);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(130)))), ((int)(((byte)(114)))));
            this.panelTitleBar.Controls.Add(this.panel2);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1233, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.iconBtnClose);
            this.panel2.Controls.Add(this.iconBtnMaximize);
            this.panel2.Controls.Add(this.iconBtnMinimize);
            this.panel2.Location = new System.Drawing.Point(1114, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 28);
            this.panel2.TabIndex = 0;
            // 
            // iconBtnClose
            // 
            this.iconBtnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBtnClose.FlatAppearance.BorderSize = 0;
            this.iconBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.iconBtnClose.IconColor = System.Drawing.Color.DarkGray;
            this.iconBtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconBtnClose.IconSize = 20;
            this.iconBtnClose.Location = new System.Drawing.Point(70, 0);
            this.iconBtnClose.Name = "iconBtnClose";
            this.iconBtnClose.Size = new System.Drawing.Size(35, 28);
            this.iconBtnClose.TabIndex = 2;
            this.iconBtnClose.UseVisualStyleBackColor = true;
            this.iconBtnClose.Click += new System.EventHandler(this.iconBtnClose_Click);
            // 
            // iconBtnMaximize
            // 
            this.iconBtnMaximize.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBtnMaximize.FlatAppearance.BorderSize = 0;
            this.iconBtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMaximize.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.iconBtnMaximize.IconColor = System.Drawing.Color.DarkGray;
            this.iconBtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMaximize.IconSize = 25;
            this.iconBtnMaximize.Location = new System.Drawing.Point(35, 0);
            this.iconBtnMaximize.Name = "iconBtnMaximize";
            this.iconBtnMaximize.Size = new System.Drawing.Size(35, 28);
            this.iconBtnMaximize.TabIndex = 1;
            this.iconBtnMaximize.UseVisualStyleBackColor = true;
            this.iconBtnMaximize.Click += new System.EventHandler(this.iconBtnMaximize_Click);
            // 
            // iconBtnMinimize
            // 
            this.iconBtnMinimize.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconBtnMinimize.FlatAppearance.BorderSize = 0;
            this.iconBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnMinimize.IconColor = System.Drawing.Color.DarkGray;
            this.iconBtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMinimize.IconSize = 25;
            this.iconBtnMinimize.Location = new System.Drawing.Point(0, 0);
            this.iconBtnMinimize.Name = "iconBtnMinimize";
            this.iconBtnMinimize.Size = new System.Drawing.Size(35, 28);
            this.iconBtnMinimize.TabIndex = 0;
            this.iconBtnMinimize.UseVisualStyleBackColor = true;
            this.iconBtnMinimize.Click += new System.EventHandler(this.iconBtnMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(60, 32);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(52, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(130)))), ((int)(((byte)(114)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(102)))), ((int)(((byte)(90)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1233, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(149)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1233, 592);
            this.panelDesktop.TabIndex = 3;
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconMenuItem1.IconColor = System.Drawing.Color.Black;
            this.iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.iconMenuItem1.Text = "iconMenuItem1";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 676);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPrincipal";
            this.Text = "fmrPrincipal";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconBtnAjustes;
        private FontAwesome.Sharp.IconButton iconBtnAgregar;
        private FontAwesome.Sharp.IconButton iconBtnListar;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconBtnClose;
        private FontAwesome.Sharp.IconButton iconBtnMaximize;
        private FontAwesome.Sharp.IconButton iconBtnMinimize;
    }
}