namespace proyectoFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usuarioEntrada = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TextEntLabel = new System.Windows.Forms.Label();
            this.ConectarB = new System.Windows.Forms.Button();
            this.UsuarioL = new System.Windows.Forms.Label();
            this.ContaL = new System.Windows.Forms.Label();
            this.contraseñaEntrada = new System.Windows.Forms.TextBox();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuarioEntrada
            // 
            this.usuarioEntrada.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioEntrada.Location = new System.Drawing.Point(11, 261);
            this.usuarioEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.usuarioEntrada.Name = "usuarioEntrada";
            this.usuarioEntrada.Size = new System.Drawing.Size(140, 23);
            this.usuarioEntrada.TabIndex = 0;
            this.usuarioEntrada.Text = "postgres";
            this.usuarioEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TextEntLabel
            // 
            this.TextEntLabel.AutoSize = true;
            this.TextEntLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEntLabel.Location = new System.Drawing.Point(32, 187);
            this.TextEntLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextEntLabel.Name = "TextEntLabel";
            this.TextEntLabel.Size = new System.Drawing.Size(99, 18);
            this.TextEntLabel.TabIndex = 2;
            this.TextEntLabel.Text = "SALUBRIDAD";
            this.TextEntLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ConectarB
            // 
            this.ConectarB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConectarB.Location = new System.Drawing.Point(11, 382);
            this.ConectarB.Margin = new System.Windows.Forms.Padding(2);
            this.ConectarB.Name = "ConectarB";
            this.ConectarB.Size = new System.Drawing.Size(140, 36);
            this.ConectarB.TabIndex = 3;
            this.ConectarB.Text = "Conectar";
            this.ConectarB.UseVisualStyleBackColor = true;
            this.ConectarB.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // UsuarioL
            // 
            this.UsuarioL.AutoSize = true;
            this.UsuarioL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.UsuarioL.Location = new System.Drawing.Point(52, 227);
            this.UsuarioL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsuarioL.Name = "UsuarioL";
            this.UsuarioL.Size = new System.Drawing.Size(63, 20);
            this.UsuarioL.TabIndex = 4;
            this.UsuarioL.Text = "Usuario";
            // 
            // ContaL
            // 
            this.ContaL.AutoSize = true;
            this.ContaL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ContaL.Location = new System.Drawing.Point(31, 301);
            this.ContaL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ContaL.Name = "ContaL";
            this.ContaL.Size = new System.Drawing.Size(95, 20);
            this.ContaL.TabIndex = 5;
            this.ContaL.Text = "Contraseña";
            // 
            // contraseñaEntrada
            // 
            this.contraseñaEntrada.Location = new System.Drawing.Point(11, 337);
            this.contraseñaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.contraseñaEntrada.Name = "contraseñaEntrada";
            this.contraseñaEntrada.Size = new System.Drawing.Size(140, 20);
            this.contraseñaEntrada.TabIndex = 6;
            this.contraseñaEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseñaEntrada.UseSystemPasswordChar = true;
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(165, 39);
            this.TituloPanel.TabIndex = 27;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.White;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(130, 0);
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
            this.minimizar.BackColor = System.Drawing.Color.White;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(60, -1);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 40);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.White;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(95, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 39);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectoFinal.Properties.Resources.Sin_título;
            this.pictureBox1.InitialImage = global::proyectoFinal.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(165, 429);
            this.Controls.Add(this.TituloPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.contraseñaEntrada);
            this.Controls.Add(this.ContaL);
            this.Controls.Add(this.UsuarioL);
            this.Controls.Add(this.ConectarB);
            this.Controls.Add(this.TextEntLabel);
            this.Controls.Add(this.usuarioEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usuarioEntrada;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label TextEntLabel;
        private System.Windows.Forms.Button ConectarB;
        private System.Windows.Forms.Label UsuarioL;
        private System.Windows.Forms.Label ContaL;
        private System.Windows.Forms.TextBox contraseñaEntrada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
    }
}

