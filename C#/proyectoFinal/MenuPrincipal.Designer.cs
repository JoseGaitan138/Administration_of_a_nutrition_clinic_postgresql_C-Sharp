namespace proyectoFinal
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRutina = new System.Windows.Forms.Button();
            this.productoBotton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.TituloPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.TituloPanel.Controls.Add(this.label1);
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(1030, 38);
            this.TituloPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cartera de Alimentación Correcta y Actividad Física";
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(994, 0);
            this.cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 39);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(924, -1);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 39);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(959, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 39);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.btnAlimentos);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.buttonRutina);
            this.panelMenu.Controls.Add(this.productoBotton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 38);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(167, 517);
            this.panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Metas";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRutina
            // 
            this.buttonRutina.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRutina.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRutina.Image = ((System.Drawing.Image)(resources.GetObject("buttonRutina.Image")));
            this.buttonRutina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRutina.Location = new System.Drawing.Point(0, 46);
            this.buttonRutina.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRutina.Name = "buttonRutina";
            this.buttonRutina.Size = new System.Drawing.Size(167, 46);
            this.buttonRutina.TabIndex = 1;
            this.buttonRutina.Text = "Rutina";
            this.buttonRutina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRutina.UseVisualStyleBackColor = false;
            this.buttonRutina.Click += new System.EventHandler(this.buttonRutina_Click);
            // 
            // productoBotton
            // 
            this.productoBotton.BackColor = System.Drawing.Color.RoyalBlue;
            this.productoBotton.Dock = System.Windows.Forms.DockStyle.Top;
            this.productoBotton.Image = ((System.Drawing.Image)(resources.GetObject("productoBotton.Image")));
            this.productoBotton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productoBotton.Location = new System.Drawing.Point(0, 0);
            this.productoBotton.Margin = new System.Windows.Forms.Padding(2);
            this.productoBotton.Name = "productoBotton";
            this.productoBotton.Size = new System.Drawing.Size(167, 46);
            this.productoBotton.TabIndex = 0;
            this.productoBotton.Text = "Afiliado";
            this.productoBotton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.productoBotton.UseVisualStyleBackColor = false;
            this.productoBotton.Click += new System.EventHandler(this.ProductoBotton_Click);
            this.productoBotton.MouseEnter += new System.EventHandler(this.ProductoBotton_MouseEnter);
            this.productoBotton.MouseLeave += new System.EventHandler(this.ProductoBotton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(172, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(845, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAlimentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnAlimentos.Image")));
            this.btnAlimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlimentos.Location = new System.Drawing.Point(0, 138);
            this.btnAlimentos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(167, 46);
            this.btnAlimentos.TabIndex = 3;
            this.btnAlimentos.Text = "Alimentos";
            this.btnAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlimentos.UseVisualStyleBackColor = false;
            this.btnAlimentos.Click += new System.EventHandler(this.BtnAlimentos_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1030, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.TituloPanel.ResumeLayout(false);
            this.TituloPanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button productoBotton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRutina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAlimentos;
    }
}