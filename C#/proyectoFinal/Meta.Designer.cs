namespace proyectoFinal
{
    partial class Meta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meta));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porNSS = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.pesoIniEntrada = new System.Windows.Forms.TextBox();
            this.pesoIniL = new System.Windows.Forms.Label();
            this.fechaIniEntrada = new System.Windows.Forms.TextBox();
            this.FechaIniL = new System.Windows.Forms.Label();
            this.NSSEntada = new System.Windows.Forms.TextBox();
            this.NSSL = new System.Windows.Forms.Label();
            this.datosL = new System.Windows.Forms.Label();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.eliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.aceptarB = new System.Windows.Forms.Button();
            this.listaMetas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.circunferenciaEntrada = new System.Windows.Forms.TextBox();
            this.FechaConL = new System.Windows.Forms.Label();
            this.FechaConEntrada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pesoMetaEntrada = new System.Windows.Forms.TextBox();
            this.Menu.SuspendLayout();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMetas)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bucarToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 39);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(825, 24);
            this.Menu.TabIndex = 54;
            this.Menu.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porIDToolStripMenuItem,
            this.porNSS,
            this.mostrarTodo});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porIDToolStripMenuItem
            // 
            this.porIDToolStripMenuItem.Name = "porIDToolStripMenuItem";
            this.porIDToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.porIDToolStripMenuItem.Text = "Por ID ";
            this.porIDToolStripMenuItem.Click += new System.EventHandler(this.PorIDToolStripMenuItem_Click);
            // 
            // porNSS
            // 
            this.porNSS.Name = "porNSS";
            this.porNSS.Size = new System.Drawing.Size(143, 22);
            this.porNSS.Text = "Por NSS";
            this.porNSS.Click += new System.EventHandler(this.PorNSS_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(143, 22);
            this.mostrarTodo.Text = "Mostrar todo";
            this.mostrarTodo.Click += new System.EventHandler(this.MostrarTodo_Click);
            // 
            // TituloPanel
            // 
            this.TituloPanel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.TituloPanel.Controls.Add(this.button1);
            this.TituloPanel.Controls.Add(this.label1);
            this.TituloPanel.Controls.Add(this.cerrar);
            this.TituloPanel.Controls.Add(this.minimizar);
            this.TituloPanel.Controls.Add(this.maximizar);
            this.TituloPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TituloPanel.Location = new System.Drawing.Point(0, 0);
            this.TituloPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TituloPanel.Name = "TituloPanel";
            this.TituloPanel.Size = new System.Drawing.Size(825, 39);
            this.TituloPanel.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(790, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 39);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.label1.Location = new System.Drawing.Point(288, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meta de perdida de peso";
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Location = new System.Drawing.Point(790, 0);
            this.cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 39);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = false;
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Location = new System.Drawing.Point(719, -1);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 39);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = false;
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Location = new System.Drawing.Point(754, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 39);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            // 
            // pesoIniEntrada
            // 
            this.pesoIniEntrada.Location = new System.Drawing.Point(580, 196);
            this.pesoIniEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.pesoIniEntrada.Name = "pesoIniEntrada";
            this.pesoIniEntrada.Size = new System.Drawing.Size(140, 20);
            this.pesoIniEntrada.TabIndex = 95;
            // 
            // pesoIniL
            // 
            this.pesoIniL.AutoSize = true;
            this.pesoIniL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.pesoIniL.Location = new System.Drawing.Point(577, 176);
            this.pesoIniL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pesoIniL.Name = "pesoIniL";
            this.pesoIniL.Size = new System.Drawing.Size(91, 20);
            this.pesoIniL.TabIndex = 94;
            this.pesoIniL.Text = "Peso Inicial";
            // 
            // fechaIniEntrada
            // 
            this.fechaIniEntrada.Location = new System.Drawing.Point(579, 236);
            this.fechaIniEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.fechaIniEntrada.Name = "fechaIniEntrada";
            this.fechaIniEntrada.Size = new System.Drawing.Size(140, 20);
            this.fechaIniEntrada.TabIndex = 89;
            // 
            // FechaIniL
            // 
            this.FechaIniL.AutoSize = true;
            this.FechaIniL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.FechaIniL.Location = new System.Drawing.Point(577, 216);
            this.FechaIniL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaIniL.Name = "FechaIniL";
            this.FechaIniL.Size = new System.Drawing.Size(121, 20);
            this.FechaIniL.TabIndex = 88;
            this.FechaIniL.Text = "Fecha de inicio";
            // 
            // NSSEntada
            // 
            this.NSSEntada.Location = new System.Drawing.Point(579, 115);
            this.NSSEntada.Margin = new System.Windows.Forms.Padding(2);
            this.NSSEntada.Name = "NSSEntada";
            this.NSSEntada.Size = new System.Drawing.Size(140, 20);
            this.NSSEntada.TabIndex = 87;
            // 
            // NSSL
            // 
            this.NSSL.AutoSize = true;
            this.NSSL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NSSL.Location = new System.Drawing.Point(576, 96);
            this.NSSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NSSL.Name = "NSSL";
            this.NSSL.Size = new System.Drawing.Size(34, 20);
            this.NSSL.TabIndex = 86;
            this.NSSL.Text = "NSS";
            // 
            // datosL
            // 
            this.datosL.AutoSize = true;
            this.datosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datosL.Location = new System.Drawing.Point(576, 69);
            this.datosL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datosL.Name = "datosL";
            this.datosL.Size = new System.Drawing.Size(51, 20);
            this.datosL.TabIndex = 85;
            this.datosL.Text = "Datos";
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(752, 336);
            this.LimpiarB.Margin = new System.Windows.Forms.Padding(2);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(64, 38);
            this.LimpiarB.TabIndex = 84;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // eliminarB
            // 
            this.eliminarB.Location = new System.Drawing.Point(752, 293);
            this.eliminarB.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(64, 38);
            this.eliminarB.TabIndex = 83;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = true;
            this.eliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(752, 250);
            this.ModificarB.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(64, 38);
            this.ModificarB.TabIndex = 82;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(296, 410);
            this.aceptBus.Margin = new System.Windows.Forms.Padding(2);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(64, 38);
            this.aceptBus.TabIndex = 81;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.AceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(296, 388);
            this.datoBusEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(140, 20);
            this.datoBusEntrada.TabIndex = 80;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(292, 360);
            this.datoBuscarL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(119, 20);
            this.datoBuscarL.TabIndex = 79;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // aceptarB
            // 
            this.aceptarB.Location = new System.Drawing.Point(752, 207);
            this.aceptarB.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(64, 38);
            this.aceptarB.TabIndex = 78;
            this.aceptarB.Text = "Agregar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.AceptarB_Click);
            // 
            // listaMetas
            // 
            this.listaMetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaMetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaMetas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaMetas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaMetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaMetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaMetas.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaMetas.Location = new System.Drawing.Point(16, 78);
            this.listaMetas.Margin = new System.Windows.Forms.Padding(2);
            this.listaMetas.Name = "listaMetas";
            this.listaMetas.RowHeadersWidth = 51;
            this.listaMetas.RowTemplate.Height = 24;
            this.listaMetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaMetas.Size = new System.Drawing.Size(554, 251);
            this.listaMetas.TabIndex = 75;
            this.listaMetas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaMetas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(576, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Circunferencia abdominal";
            // 
            // circunferenciaEntrada
            // 
            this.circunferenciaEntrada.Location = new System.Drawing.Point(580, 155);
            this.circunferenciaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.circunferenciaEntrada.Name = "circunferenciaEntrada";
            this.circunferenciaEntrada.Size = new System.Drawing.Size(140, 20);
            this.circunferenciaEntrada.TabIndex = 101;
            // 
            // FechaConL
            // 
            this.FechaConL.AutoSize = true;
            this.FechaConL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.FechaConL.Location = new System.Drawing.Point(576, 256);
            this.FechaConL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaConL.Name = "FechaConL";
            this.FechaConL.Size = new System.Drawing.Size(170, 20);
            this.FechaConL.TabIndex = 102;
            this.FechaConL.Text = "Fecha de conclucion ";
            // 
            // FechaConEntrada
            // 
            this.FechaConEntrada.Location = new System.Drawing.Point(579, 276);
            this.FechaConEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.FechaConEntrada.Name = "FechaConEntrada";
            this.FechaConEntrada.Size = new System.Drawing.Size(140, 20);
            this.FechaConEntrada.TabIndex = 103;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(578, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Peso meta";
            // 
            // pesoMetaEntrada
            // 
            this.pesoMetaEntrada.Location = new System.Drawing.Point(579, 317);
            this.pesoMetaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.pesoMetaEntrada.Name = "pesoMetaEntrada";
            this.pesoMetaEntrada.Size = new System.Drawing.Size(140, 20);
            this.pesoMetaEntrada.TabIndex = 105;
            // 
            // Meta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 488);
            this.Controls.Add(this.pesoMetaEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaConEntrada);
            this.Controls.Add(this.FechaConL);
            this.Controls.Add(this.circunferenciaEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pesoIniEntrada);
            this.Controls.Add(this.pesoIniL);
            this.Controls.Add(this.fechaIniEntrada);
            this.Controls.Add(this.FechaIniL);
            this.Controls.Add(this.NSSEntada);
            this.Controls.Add(this.NSSL);
            this.Controls.Add(this.datosL);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.listaMetas);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Meta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.TituloPanel.ResumeLayout(false);
            this.TituloPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaMetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porNSS;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodo;
        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pesoIniEntrada;
        private System.Windows.Forms.Label pesoIniL;
        private System.Windows.Forms.TextBox fechaIniEntrada;
        private System.Windows.Forms.Label FechaIniL;
        private System.Windows.Forms.TextBox NSSEntada;
        private System.Windows.Forms.Label NSSL;
        private System.Windows.Forms.Label datosL;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Button eliminarB;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Label datoBuscarL;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.DataGridView listaMetas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox circunferenciaEntrada;
        private System.Windows.Forms.Label FechaConL;
        private System.Windows.Forms.TextBox FechaConEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pesoMetaEntrada;
        private System.Windows.Forms.ToolStripMenuItem porIDToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}