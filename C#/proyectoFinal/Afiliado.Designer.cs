namespace proyectoFinal
{
    partial class Afiliado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Afiliado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.eliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.aceptarB = new System.Windows.Forms.Button();
            this.nombreL = new System.Windows.Forms.Label();
            this.nombreEntrada = new System.Windows.Forms.TextBox();
            this.listaAlmacen = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porId = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.NSSL = new System.Windows.Forms.Label();
            this.datosL = new System.Windows.Forms.Label();
            this.NSSEntada = new System.Windows.Forms.TextBox();
            this.FechaL = new System.Windows.Forms.Label();
            this.fechaEntrada = new System.Windows.Forms.TextBox();
            this.sexoL = new System.Windows.Forms.Label();
            this.sexoEntrada = new System.Windows.Forms.TextBox();
            this.edadL = new System.Windows.Forms.Label();
            this.edadEntrada = new System.Windows.Forms.TextBox();
            this.pesoL = new System.Windows.Forms.Label();
            this.pesoEntrada = new System.Windows.Forms.TextBox();
            this.alturaL = new System.Windows.Forms.Label();
            this.alturaEntrada = new System.Windows.Forms.TextBox();
            this.enfermedadesL = new System.Windows.Forms.Label();
            this.enfermedadesEntrada = new System.Windows.Forms.TextBox();
            this.MasaEntrada = new System.Windows.Forms.TextBox();
            this.MasaL = new System.Windows.Forms.Label();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaAlmacen)).BeginInit();
            this.menuStrip1.SuspendLayout();
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
            this.TituloPanel.Size = new System.Drawing.Size(825, 39);
            this.TituloPanel.TabIndex = 27;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(790, 0);
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
            this.minimizar.Location = new System.Drawing.Point(719, -1);
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
            this.maximizar.Location = new System.Drawing.Point(754, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 39);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(730, 140);
            this.LimpiarB.Margin = new System.Windows.Forms.Padding(2);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(64, 38);
            this.LimpiarB.TabIndex = 47;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // eliminarB
            // 
            this.eliminarB.Location = new System.Drawing.Point(730, 197);
            this.eliminarB.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(64, 38);
            this.eliminarB.TabIndex = 46;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = true;
            this.eliminarB.Click += new System.EventHandler(this.EliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(730, 246);
            this.ModificarB.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(64, 38);
            this.ModificarB.TabIndex = 45;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(302, 407);
            this.aceptBus.Margin = new System.Windows.Forms.Padding(2);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(64, 38);
            this.aceptBus.TabIndex = 44;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.AceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(302, 384);
            this.datoBusEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(140, 20);
            this.datoBusEntrada.TabIndex = 43;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(299, 357);
            this.datoBuscarL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(119, 20);
            this.datoBuscarL.TabIndex = 42;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // aceptarB
            // 
            this.aceptarB.Location = new System.Drawing.Point(730, 295);
            this.aceptarB.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(64, 38);
            this.aceptarB.TabIndex = 41;
            this.aceptarB.Text = "Agregar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.AceptarB_Click);
            // 
            // nombreL
            // 
            this.nombreL.AutoSize = true;
            this.nombreL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.nombreL.Location = new System.Drawing.Point(554, 133);
            this.nombreL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreL.Name = "nombreL";
            this.nombreL.Size = new System.Drawing.Size(68, 20);
            this.nombreL.TabIndex = 30;
            this.nombreL.Text = "Nombre";
            // 
            // nombreEntrada
            // 
            this.nombreEntrada.Location = new System.Drawing.Point(556, 154);
            this.nombreEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.nombreEntrada.Name = "nombreEntrada";
            this.nombreEntrada.Size = new System.Drawing.Size(140, 20);
            this.nombreEntrada.TabIndex = 29;
            // 
            // listaAlmacen
            // 
            this.listaAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaAlmacen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaAlmacen.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaAlmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaAlmacen.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaAlmacen.Location = new System.Drawing.Point(9, 89);
            this.listaAlmacen.Margin = new System.Windows.Forms.Padding(2);
            this.listaAlmacen.Name = "listaAlmacen";
            this.listaAlmacen.RowHeadersWidth = 51;
            this.listaAlmacen.RowTemplate.Height = 24;
            this.listaAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaAlmacen.Size = new System.Drawing.Size(525, 244);
            this.listaAlmacen.TabIndex = 28;
            this.listaAlmacen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListaAlmacen_CellContentClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 52;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porId,
            this.porNombre,
            this.mostrarTodo});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porId
            // 
            this.porId.Name = "porId";
            this.porId.Size = new System.Drawing.Size(143, 22);
            this.porId.Text = "Por NSS";
            this.porId.Click += new System.EventHandler(this.PorId_Click);
            // 
            // porNombre
            // 
            this.porNombre.Name = "porNombre";
            this.porNombre.Size = new System.Drawing.Size(143, 22);
            this.porNombre.Text = "Por Nombre";
            this.porNombre.Click += new System.EventHandler(this.PorModelo_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(143, 22);
            this.mostrarTodo.Text = "Mostrar todo";
            this.mostrarTodo.Click += new System.EventHandler(this.Todo_Click);
            // 
            // NSSL
            // 
            this.NSSL.AutoSize = true;
            this.NSSL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NSSL.Location = new System.Drawing.Point(554, 94);
            this.NSSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NSSL.Name = "NSSL";
            this.NSSL.Size = new System.Drawing.Size(34, 20);
            this.NSSL.TabIndex = 58;
            this.NSSL.Text = "NSS";
            // 
            // datosL
            // 
            this.datosL.AutoSize = true;
            this.datosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datosL.Location = new System.Drawing.Point(554, 68);
            this.datosL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datosL.Name = "datosL";
            this.datosL.Size = new System.Drawing.Size(136, 20);
            this.datosL.TabIndex = 56;
            this.datosL.Text = "Datos del afiliado";
            // 
            // NSSEntada
            // 
            this.NSSEntada.Location = new System.Drawing.Point(556, 114);
            this.NSSEntada.Margin = new System.Windows.Forms.Padding(2);
            this.NSSEntada.Name = "NSSEntada";
            this.NSSEntada.Size = new System.Drawing.Size(140, 20);
            this.NSSEntada.TabIndex = 61;
            // 
            // FechaL
            // 
            this.FechaL.AutoSize = true;
            this.FechaL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.FechaL.Location = new System.Drawing.Point(554, 174);
            this.FechaL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FechaL.Name = "FechaL";
            this.FechaL.Size = new System.Drawing.Size(55, 20);
            this.FechaL.TabIndex = 63;
            this.FechaL.Text = "Fecha";
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.Location = new System.Drawing.Point(556, 194);
            this.fechaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.Size = new System.Drawing.Size(140, 20);
            this.fechaEntrada.TabIndex = 64;
            // 
            // sexoL
            // 
            this.sexoL.AutoSize = true;
            this.sexoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.sexoL.Location = new System.Drawing.Point(554, 214);
            this.sexoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sexoL.Name = "sexoL";
            this.sexoL.Size = new System.Drawing.Size(43, 20);
            this.sexoL.TabIndex = 65;
            this.sexoL.Text = "Sexo";
            // 
            // sexoEntrada
            // 
            this.sexoEntrada.Location = new System.Drawing.Point(556, 235);
            this.sexoEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.sexoEntrada.Name = "sexoEntrada";
            this.sexoEntrada.Size = new System.Drawing.Size(140, 20);
            this.sexoEntrada.TabIndex = 66;
            // 
            // edadL
            // 
            this.edadL.AutoSize = true;
            this.edadL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.edadL.Location = new System.Drawing.Point(554, 255);
            this.edadL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edadL.Name = "edadL";
            this.edadL.Size = new System.Drawing.Size(47, 20);
            this.edadL.TabIndex = 67;
            this.edadL.Text = "Edad";
            // 
            // edadEntrada
            // 
            this.edadEntrada.Location = new System.Drawing.Point(556, 275);
            this.edadEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.edadEntrada.Name = "edadEntrada";
            this.edadEntrada.Size = new System.Drawing.Size(140, 20);
            this.edadEntrada.TabIndex = 68;
            // 
            // pesoL
            // 
            this.pesoL.AutoSize = true;
            this.pesoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.pesoL.Location = new System.Drawing.Point(553, 296);
            this.pesoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pesoL.Name = "pesoL";
            this.pesoL.Size = new System.Drawing.Size(44, 20);
            this.pesoL.TabIndex = 69;
            this.pesoL.Text = "Peso";
            // 
            // pesoEntrada
            // 
            this.pesoEntrada.Location = new System.Drawing.Point(556, 316);
            this.pesoEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.pesoEntrada.Name = "pesoEntrada";
            this.pesoEntrada.Size = new System.Drawing.Size(140, 20);
            this.pesoEntrada.TabIndex = 70;
            // 
            // alturaL
            // 
            this.alturaL.AutoSize = true;
            this.alturaL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.alturaL.Location = new System.Drawing.Point(554, 336);
            this.alturaL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.alturaL.Name = "alturaL";
            this.alturaL.Size = new System.Drawing.Size(52, 20);
            this.alturaL.TabIndex = 71;
            this.alturaL.Text = "Altura";
            // 
            // alturaEntrada
            // 
            this.alturaEntrada.Location = new System.Drawing.Point(556, 357);
            this.alturaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.alturaEntrada.Name = "alturaEntrada";
            this.alturaEntrada.Size = new System.Drawing.Size(140, 20);
            this.alturaEntrada.TabIndex = 72;
            // 
            // enfermedadesL
            // 
            this.enfermedadesL.AutoSize = true;
            this.enfermedadesL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.enfermedadesL.Location = new System.Drawing.Point(553, 424);
            this.enfermedadesL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enfermedadesL.Name = "enfermedadesL";
            this.enfermedadesL.Size = new System.Drawing.Size(115, 20);
            this.enfermedadesL.TabIndex = 73;
            this.enfermedadesL.Text = "Enfermedades";
            // 
            // enfermedadesEntrada
            // 
            this.enfermedadesEntrada.Location = new System.Drawing.Point(556, 444);
            this.enfermedadesEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.enfermedadesEntrada.Name = "enfermedadesEntrada";
            this.enfermedadesEntrada.Size = new System.Drawing.Size(140, 20);
            this.enfermedadesEntrada.TabIndex = 74;
            // 
            // MasaEntrada
            // 
            this.MasaEntrada.Location = new System.Drawing.Point(556, 402);
            this.MasaEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.MasaEntrada.Name = "MasaEntrada";
            this.MasaEntrada.Size = new System.Drawing.Size(140, 20);
            this.MasaEntrada.TabIndex = 76;
            // 
            // MasaL
            // 
            this.MasaL.AutoSize = true;
            this.MasaL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.MasaL.Location = new System.Drawing.Point(553, 382);
            this.MasaL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MasaL.Name = "MasaL";
            this.MasaL.Size = new System.Drawing.Size(125, 20);
            this.MasaL.TabIndex = 75;
            this.MasaL.Text = "Indice de Masa";
            // 
            // Afiliado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 517);
            this.Controls.Add(this.MasaEntrada);
            this.Controls.Add(this.MasaL);
            this.Controls.Add(this.enfermedadesEntrada);
            this.Controls.Add(this.enfermedadesL);
            this.Controls.Add(this.alturaEntrada);
            this.Controls.Add(this.alturaL);
            this.Controls.Add(this.pesoEntrada);
            this.Controls.Add(this.pesoL);
            this.Controls.Add(this.edadEntrada);
            this.Controls.Add(this.edadL);
            this.Controls.Add(this.sexoEntrada);
            this.Controls.Add(this.sexoL);
            this.Controls.Add(this.fechaEntrada);
            this.Controls.Add(this.FechaL);
            this.Controls.Add(this.NSSEntada);
            this.Controls.Add(this.NSSL);
            this.Controls.Add(this.datosL);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.nombreL);
            this.Controls.Add(this.nombreEntrada);
            this.Controls.Add(this.listaAlmacen);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Afiliado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "alta_zapato";
            this.TituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaAlmacen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TituloPanel;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Button minimizar;
        private System.Windows.Forms.Button maximizar;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Button eliminarB;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Label datoBuscarL;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.Label nombreL;
        private System.Windows.Forms.TextBox nombreEntrada;
        private System.Windows.Forms.DataGridView listaAlmacen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porId;
        private System.Windows.Forms.ToolStripMenuItem porNombre;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodo;
        private System.Windows.Forms.Label NSSL;
        private System.Windows.Forms.Label datosL;
        private System.Windows.Forms.TextBox NSSEntada;
        private System.Windows.Forms.Label FechaL;
        private System.Windows.Forms.TextBox fechaEntrada;
        private System.Windows.Forms.Label sexoL;
        private System.Windows.Forms.TextBox sexoEntrada;
        private System.Windows.Forms.Label edadL;
        private System.Windows.Forms.TextBox edadEntrada;
        private System.Windows.Forms.Label pesoL;
        private System.Windows.Forms.TextBox pesoEntrada;
        private System.Windows.Forms.Label alturaL;
        private System.Windows.Forms.TextBox alturaEntrada;
        private System.Windows.Forms.Label enfermedadesL;
        private System.Windows.Forms.TextBox enfermedadesEntrada;
        private System.Windows.Forms.TextBox MasaEntrada;
        private System.Windows.Forms.Label MasaL;
    }
}