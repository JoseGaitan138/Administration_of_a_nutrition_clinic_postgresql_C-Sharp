namespace proyectoFinal
{
    partial class Alimento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alimento));
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.verdurasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerealesYTuberculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leguminosasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alimentosDeOrigenAnimalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lacteosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aceitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelNombreAlimento = new System.Windows.Forms.Label();
            this.labelRacion = new System.Windows.Forms.Label();
            this.labelCantRacion = new System.Windows.Forms.Label();
            this.labelCalorias = new System.Windows.Forms.Label();
            this.labelCantCalorias = new System.Windows.Forms.Label();
            this.labelGrupo = new System.Windows.Forms.Label();
            this.labelGrupoAlimentacionNombre = new System.Windows.Forms.Label();
            this.labelCaloriasTotales = new System.Windows.Forms.Label();
            this.labelCaloriasTotalesCant = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.labelInfoComida = new System.Windows.Forms.Label();
            this.btnAgregarMenu = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNss = new System.Windows.Forms.Label();
            this.TituloPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(800, 39);
            this.TituloPanel.TabIndex = 28;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(765, 0);
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
            this.minimizar.Location = new System.Drawing.Point(694, -1);
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
            this.maximizar.Location = new System.Drawing.Point(729, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 39);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bucarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 39);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 53;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porNombre,
            this.mostrarTodo});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.bucarToolStripMenuItem.Text = "Buscar";
            // 
            // porNombre
            // 
            this.porNombre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verdurasToolStripMenuItem,
            this.frutasToolStripMenuItem,
            this.cerealesYTuberculosToolStripMenuItem,
            this.leguminosasToolStripMenuItem,
            this.alimentosDeOrigenAnimalToolStripMenuItem,
            this.lacteosToolStripMenuItem,
            this.aceitesToolStripMenuItem});
            this.porNombre.Name = "porNombre";
            this.porNombre.Size = new System.Drawing.Size(180, 22);
            this.porNombre.Text = "Por Grupo";
            // 
            // verdurasToolStripMenuItem
            // 
            this.verdurasToolStripMenuItem.Name = "verdurasToolStripMenuItem";
            this.verdurasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.verdurasToolStripMenuItem.Text = "Verduras";
            this.verdurasToolStripMenuItem.Click += new System.EventHandler(this.VerdurasToolStripMenuItem_Click);
            // 
            // frutasToolStripMenuItem
            // 
            this.frutasToolStripMenuItem.Name = "frutasToolStripMenuItem";
            this.frutasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.frutasToolStripMenuItem.Text = "Frutas";
            this.frutasToolStripMenuItem.Click += new System.EventHandler(this.FrutasToolStripMenuItem_Click);
            // 
            // cerealesYTuberculosToolStripMenuItem
            // 
            this.cerealesYTuberculosToolStripMenuItem.Name = "cerealesYTuberculosToolStripMenuItem";
            this.cerealesYTuberculosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.cerealesYTuberculosToolStripMenuItem.Text = "Cereales y tuberculos";
            this.cerealesYTuberculosToolStripMenuItem.Click += new System.EventHandler(this.CerealesYTuberculosToolStripMenuItem_Click);
            // 
            // leguminosasToolStripMenuItem
            // 
            this.leguminosasToolStripMenuItem.Name = "leguminosasToolStripMenuItem";
            this.leguminosasToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.leguminosasToolStripMenuItem.Text = "Leguminosas";
            this.leguminosasToolStripMenuItem.Click += new System.EventHandler(this.LeguminosasToolStripMenuItem_Click);
            // 
            // alimentosDeOrigenAnimalToolStripMenuItem
            // 
            this.alimentosDeOrigenAnimalToolStripMenuItem.Name = "alimentosDeOrigenAnimalToolStripMenuItem";
            this.alimentosDeOrigenAnimalToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.alimentosDeOrigenAnimalToolStripMenuItem.Text = "Alimentos de origen animal";
            this.alimentosDeOrigenAnimalToolStripMenuItem.Click += new System.EventHandler(this.AlimentosDeOrigenAnimalToolStripMenuItem_Click);
            // 
            // lacteosToolStripMenuItem
            // 
            this.lacteosToolStripMenuItem.Name = "lacteosToolStripMenuItem";
            this.lacteosToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.lacteosToolStripMenuItem.Text = "Lacteos";
            this.lacteosToolStripMenuItem.Click += new System.EventHandler(this.LacteosToolStripMenuItem_Click);
            // 
            // aceitesToolStripMenuItem
            // 
            this.aceitesToolStripMenuItem.Name = "aceitesToolStripMenuItem";
            this.aceitesToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.aceitesToolStripMenuItem.Text = "Aceites";
            this.aceitesToolStripMenuItem.Click += new System.EventHandler(this.AceitesToolStripMenuItem_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(180, 22);
            this.mostrarTodo.Text = "Mostrar todo";
            this.mostrarTodo.Click += new System.EventHandler(this.MostrarTodo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(32, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(466, 289);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Enabled = false;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(539, 98);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(81, 20);
            this.labelNombre.TabIndex = 55;
            this.labelNombre.Text = "Nombre: ";
            this.labelNombre.Visible = false;
            // 
            // labelNombreAlimento
            // 
            this.labelNombreAlimento.AutoSize = true;
            this.labelNombreAlimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAlimento.Location = new System.Drawing.Point(544, 127);
            this.labelNombreAlimento.Name = "labelNombreAlimento";
            this.labelNombreAlimento.Size = new System.Drawing.Size(0, 17);
            this.labelNombreAlimento.TabIndex = 56;
            // 
            // labelRacion
            // 
            this.labelRacion.AutoSize = true;
            this.labelRacion.Enabled = false;
            this.labelRacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRacion.Location = new System.Drawing.Point(539, 155);
            this.labelRacion.Name = "labelRacion";
            this.labelRacion.Size = new System.Drawing.Size(70, 20);
            this.labelRacion.TabIndex = 57;
            this.labelRacion.Text = "Ración:";
            this.labelRacion.Visible = false;
            // 
            // labelCantRacion
            // 
            this.labelCantRacion.AutoSize = true;
            this.labelCantRacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantRacion.Location = new System.Drawing.Point(544, 185);
            this.labelCantRacion.Name = "labelCantRacion";
            this.labelCantRacion.Size = new System.Drawing.Size(0, 17);
            this.labelCantRacion.TabIndex = 58;
            // 
            // labelCalorias
            // 
            this.labelCalorias.AutoSize = true;
            this.labelCalorias.Enabled = false;
            this.labelCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCalorias.Location = new System.Drawing.Point(539, 212);
            this.labelCalorias.Name = "labelCalorias";
            this.labelCalorias.Size = new System.Drawing.Size(74, 20);
            this.labelCalorias.TabIndex = 59;
            this.labelCalorias.Text = "Calorias";
            this.labelCalorias.Visible = false;
            // 
            // labelCantCalorias
            // 
            this.labelCantCalorias.AutoSize = true;
            this.labelCantCalorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantCalorias.Location = new System.Drawing.Point(544, 241);
            this.labelCantCalorias.Name = "labelCantCalorias";
            this.labelCantCalorias.Size = new System.Drawing.Size(0, 17);
            this.labelCantCalorias.TabIndex = 60;
            // 
            // labelGrupo
            // 
            this.labelGrupo.AutoSize = true;
            this.labelGrupo.Enabled = false;
            this.labelGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupo.Location = new System.Drawing.Point(539, 274);
            this.labelGrupo.Name = "labelGrupo";
            this.labelGrupo.Size = new System.Drawing.Size(159, 20);
            this.labelGrupo.TabIndex = 61;
            this.labelGrupo.Text = "Grupo alimenticio: ";
            this.labelGrupo.Visible = false;
            // 
            // labelGrupoAlimentacionNombre
            // 
            this.labelGrupoAlimentacionNombre.AutoSize = true;
            this.labelGrupoAlimentacionNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrupoAlimentacionNombre.Location = new System.Drawing.Point(544, 305);
            this.labelGrupoAlimentacionNombre.Name = "labelGrupoAlimentacionNombre";
            this.labelGrupoAlimentacionNombre.Size = new System.Drawing.Size(0, 17);
            this.labelGrupoAlimentacionNombre.TabIndex = 62;
            // 
            // labelCaloriasTotales
            // 
            this.labelCaloriasTotales.AutoSize = true;
            this.labelCaloriasTotales.Enabled = false;
            this.labelCaloriasTotales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaloriasTotales.Location = new System.Drawing.Point(520, 409);
            this.labelCaloriasTotales.Name = "labelCaloriasTotales";
            this.labelCaloriasTotales.Size = new System.Drawing.Size(139, 20);
            this.labelCaloriasTotales.TabIndex = 63;
            this.labelCaloriasTotales.Text = "Calorias totales:";
            this.labelCaloriasTotales.Visible = false;
            // 
            // labelCaloriasTotalesCant
            // 
            this.labelCaloriasTotalesCant.AutoSize = true;
            this.labelCaloriasTotalesCant.Enabled = false;
            this.labelCaloriasTotalesCant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaloriasTotalesCant.Location = new System.Drawing.Point(665, 412);
            this.labelCaloriasTotalesCant.Name = "labelCaloriasTotalesCant";
            this.labelCaloriasTotalesCant.Size = new System.Drawing.Size(16, 17);
            this.labelCaloriasTotalesCant.TabIndex = 64;
            this.labelCaloriasTotalesCant.Text = "0";
            this.labelCaloriasTotalesCant.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Enabled = false;
            this.btnAceptar.Location = new System.Drawing.Point(543, 353);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 25);
            this.btnAceptar.TabIndex = 65;
            this.btnAceptar.Text = "Agregar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Location = new System.Drawing.Point(670, 353);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(105, 25);
            this.btnFinalizar.TabIndex = 66;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // labelInfoComida
            // 
            this.labelInfoComida.AutoSize = true;
            this.labelInfoComida.Enabled = false;
            this.labelInfoComida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoComida.Location = new System.Drawing.Point(43, 428);
            this.labelInfoComida.Name = "labelInfoComida";
            this.labelInfoComida.Size = new System.Drawing.Size(69, 20);
            this.labelInfoComida.TabIndex = 67;
            this.labelInfoComida.Text = "Comida";
            this.labelInfoComida.Visible = false;
            // 
            // btnAgregarMenu
            // 
            this.btnAgregarMenu.Enabled = false;
            this.btnAgregarMenu.Location = new System.Drawing.Point(318, 437);
            this.btnAgregarMenu.Name = "btnAgregarMenu";
            this.btnAgregarMenu.Size = new System.Drawing.Size(170, 30);
            this.btnAgregarMenu.TabIndex = 68;
            this.btnAgregarMenu.Text = "Agregar menu";
            this.btnAgregarMenu.UseVisualStyleBackColor = true;
            this.btnAgregarMenu.Visible = false;
            this.btnAgregarMenu.Click += new System.EventHandler(this.BtnAgregarMenu_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(309, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 69;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // labelNss
            // 
            this.labelNss.AutoSize = true;
            this.labelNss.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNss.Location = new System.Drawing.Point(305, 195);
            this.labelNss.Name = "labelNss";
            this.labelNss.Size = new System.Drawing.Size(128, 20);
            this.labelNss.TabIndex = 70;
            this.labelNss.Text = "Escribe tu nss:";
            // 
            // Alimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.labelNss);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAgregarMenu);
            this.Controls.Add(this.labelInfoComida);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.labelCaloriasTotalesCant);
            this.Controls.Add(this.labelCaloriasTotales);
            this.Controls.Add(this.labelGrupoAlimentacionNombre);
            this.Controls.Add(this.labelGrupo);
            this.Controls.Add(this.labelCantCalorias);
            this.Controls.Add(this.labelCalorias);
            this.Controls.Add(this.labelCantRacion);
            this.Controls.Add(this.labelRacion);
            this.Controls.Add(this.labelNombreAlimento);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alimento";
            this.TituloPanel.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNombre;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem verdurasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frutasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerealesYTuberculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leguminosasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alimentosDeOrigenAnimalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lacteosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aceitesToolStripMenuItem;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelNombreAlimento;
        private System.Windows.Forms.Label labelRacion;
        private System.Windows.Forms.Label labelCantRacion;
        private System.Windows.Forms.Label labelCalorias;
        private System.Windows.Forms.Label labelCantCalorias;
        private System.Windows.Forms.Label labelGrupo;
        private System.Windows.Forms.Label labelGrupoAlimentacionNombre;
        private System.Windows.Forms.Label labelCaloriasTotales;
        private System.Windows.Forms.Label labelCaloriasTotalesCant;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label labelInfoComida;
        private System.Windows.Forms.Button btnAgregarMenu;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNss;
    }
}