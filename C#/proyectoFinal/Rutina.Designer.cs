namespace proyectoFinal
{
    partial class Rutina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rutina));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TituloPanel = new System.Windows.Forms.Panel();
            this.cerrar = new System.Windows.Forms.Button();
            this.minimizar = new System.Windows.Forms.Button();
            this.maximizar = new System.Windows.Forms.Button();
            this.listaRutina = new System.Windows.Forms.DataGridView();
            this.LimpiarB = new System.Windows.Forms.Button();
            this.eliminarB = new System.Windows.Forms.Button();
            this.ModificarB = new System.Windows.Forms.Button();
            this.aceptarB = new System.Windows.Forms.Button();
            this.datosL = new System.Windows.Forms.Label();
            this.IDEntrada = new System.Windows.Forms.TextBox();
            this.IDL = new System.Windows.Forms.Label();
            this.NSSEntrada = new System.Windows.Forms.TextBox();
            this.NSSL = new System.Windows.Forms.Label();
            this.IntensidadEntrada = new System.Windows.Forms.TextBox();
            this.IntensidadL = new System.Windows.Forms.Label();
            this.SemanasEntrada = new System.Windows.Forms.TextBox();
            this.SemanasL = new System.Windows.Forms.Label();
            this.CalentamientoL = new System.Windows.Forms.Label();
            this.DCalentamientoEntrada = new System.Windows.Forms.TextBox();
            this.DCalentamientoL = new System.Windows.Forms.Label();
            this.CalentamientoEntrada = new System.Windows.Forms.RichTextBox();
            this.ActPEntrada = new System.Windows.Forms.TextBox();
            this.ActividadPL = new System.Windows.Forms.Label();
            this.DActPEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EnfriamientoEntrada = new System.Windows.Forms.RichTextBox();
            this.EnfriamientoL = new System.Windows.Forms.Label();
            this.DEnfriamientoEntrada = new System.Windows.Forms.TextBox();
            this.DEnfriamientoL = new System.Windows.Forms.Label();
            this.DuracionTEntrada = new System.Windows.Forms.TextBox();
            this.DuracionTL = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bucarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porId = new System.Windows.Forms.ToolStripMenuItem();
            this.porNSS = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.aceptBus = new System.Windows.Forms.Button();
            this.datoBusEntrada = new System.Windows.Forms.TextBox();
            this.datoBuscarL = new System.Windows.Forms.Label();
            this.TituloPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaRutina)).BeginInit();
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
            this.TituloPanel.Size = new System.Drawing.Size(920, 39);
            this.TituloPanel.TabIndex = 28;
            // 
            // cerrar
            // 
            this.cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cerrar.BackColor = System.Drawing.Color.Transparent;
            this.cerrar.FlatAppearance.BorderSize = 0;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrar.Image = ((System.Drawing.Image)(resources.GetObject("cerrar.Image")));
            this.cerrar.Location = new System.Drawing.Point(885, 0);
            this.cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(35, 39);
            this.cerrar.TabIndex = 0;
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // minimizar
            // 
            this.minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizar.BackColor = System.Drawing.Color.Transparent;
            this.minimizar.FlatAppearance.BorderSize = 0;
            this.minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizar.Image = ((System.Drawing.Image)(resources.GetObject("minimizar.Image")));
            this.minimizar.Location = new System.Drawing.Point(814, -1);
            this.minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.minimizar.Name = "minimizar";
            this.minimizar.Size = new System.Drawing.Size(35, 39);
            this.minimizar.TabIndex = 2;
            this.minimizar.UseVisualStyleBackColor = false;
            this.minimizar.Click += new System.EventHandler(this.minimizar_Click);
            // 
            // maximizar
            // 
            this.maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizar.BackColor = System.Drawing.Color.Transparent;
            this.maximizar.FlatAppearance.BorderSize = 0;
            this.maximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximizar.Image = ((System.Drawing.Image)(resources.GetObject("maximizar.Image")));
            this.maximizar.Location = new System.Drawing.Point(849, 0);
            this.maximizar.Margin = new System.Windows.Forms.Padding(2);
            this.maximizar.Name = "maximizar";
            this.maximizar.Size = new System.Drawing.Size(35, 39);
            this.maximizar.TabIndex = 1;
            this.maximizar.UseVisualStyleBackColor = false;
            this.maximizar.Click += new System.EventHandler(this.maximizar_Click);
            // 
            // listaRutina
            // 
            this.listaRutina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.listaRutina.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listaRutina.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.listaRutina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listaRutina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listaRutina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listaRutina.DefaultCellStyle = dataGridViewCellStyle2;
            this.listaRutina.Location = new System.Drawing.Point(16, 114);
            this.listaRutina.Margin = new System.Windows.Forms.Padding(2);
            this.listaRutina.Name = "listaRutina";
            this.listaRutina.RowHeadersWidth = 51;
            this.listaRutina.RowTemplate.Height = 24;
            this.listaRutina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaRutina.Size = new System.Drawing.Size(554, 444);
            this.listaRutina.TabIndex = 29;
            this.listaRutina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaRutina_CellContentClick);
            // 
            // LimpiarB
            // 
            this.LimpiarB.Location = new System.Drawing.Point(836, 284);
            this.LimpiarB.Margin = new System.Windows.Forms.Padding(2);
            this.LimpiarB.Name = "LimpiarB";
            this.LimpiarB.Size = new System.Drawing.Size(64, 38);
            this.LimpiarB.TabIndex = 51;
            this.LimpiarB.Text = "Limpiar";
            this.LimpiarB.UseVisualStyleBackColor = true;
            this.LimpiarB.Click += new System.EventHandler(this.LimpiarB_Click);
            // 
            // eliminarB
            // 
            this.eliminarB.Location = new System.Drawing.Point(836, 341);
            this.eliminarB.Margin = new System.Windows.Forms.Padding(2);
            this.eliminarB.Name = "eliminarB";
            this.eliminarB.Size = new System.Drawing.Size(64, 38);
            this.eliminarB.TabIndex = 50;
            this.eliminarB.Text = "Eliminar";
            this.eliminarB.UseVisualStyleBackColor = true;
            this.eliminarB.Click += new System.EventHandler(this.eliminarB_Click);
            // 
            // ModificarB
            // 
            this.ModificarB.Location = new System.Drawing.Point(836, 390);
            this.ModificarB.Margin = new System.Windows.Forms.Padding(2);
            this.ModificarB.Name = "ModificarB";
            this.ModificarB.Size = new System.Drawing.Size(64, 38);
            this.ModificarB.TabIndex = 49;
            this.ModificarB.Text = "Modificar";
            this.ModificarB.UseVisualStyleBackColor = true;
            this.ModificarB.Click += new System.EventHandler(this.ModificarB_Click);
            // 
            // aceptarB
            // 
            this.aceptarB.Location = new System.Drawing.Point(836, 439);
            this.aceptarB.Margin = new System.Windows.Forms.Padding(2);
            this.aceptarB.Name = "aceptarB";
            this.aceptarB.Size = new System.Drawing.Size(64, 38);
            this.aceptarB.TabIndex = 48;
            this.aceptarB.Text = "Agregar";
            this.aceptarB.UseVisualStyleBackColor = true;
            this.aceptarB.Click += new System.EventHandler(this.aceptarB_Click);
            // 
            // datosL
            // 
            this.datosL.AutoSize = true;
            this.datosL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datosL.Location = new System.Drawing.Point(632, 63);
            this.datosL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datosL.Name = "datosL";
            this.datosL.Size = new System.Drawing.Size(141, 20);
            this.datosL.TabIndex = 57;
            this.datosL.Text = "Datos de la Rutina";
            // 
            // IDEntrada
            // 
            this.IDEntrada.Location = new System.Drawing.Point(636, 114);
            this.IDEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.IDEntrada.Name = "IDEntrada";
            this.IDEntrada.Size = new System.Drawing.Size(140, 20);
            this.IDEntrada.TabIndex = 63;
            // 
            // IDL
            // 
            this.IDL.AutoSize = true;
            this.IDL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.IDL.Location = new System.Drawing.Point(634, 94);
            this.IDL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDL.Name = "IDL";
            this.IDL.Size = new System.Drawing.Size(74, 20);
            this.IDL.TabIndex = 62;
            this.IDL.Text = "ID Rutina";
            // 
            // NSSEntrada
            // 
            this.NSSEntrada.Location = new System.Drawing.Point(636, 164);
            this.NSSEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.NSSEntrada.Name = "NSSEntrada";
            this.NSSEntrada.Size = new System.Drawing.Size(140, 20);
            this.NSSEntrada.TabIndex = 65;
            // 
            // NSSL
            // 
            this.NSSL.AutoSize = true;
            this.NSSL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.NSSL.Location = new System.Drawing.Point(634, 144);
            this.NSSL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NSSL.Name = "NSSL";
            this.NSSL.Size = new System.Drawing.Size(93, 20);
            this.NSSL.TabIndex = 64;
            this.NSSL.Text = "NSS Afiliado";
            // 
            // IntensidadEntrada
            // 
            this.IntensidadEntrada.Location = new System.Drawing.Point(636, 215);
            this.IntensidadEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.IntensidadEntrada.Name = "IntensidadEntrada";
            this.IntensidadEntrada.Size = new System.Drawing.Size(140, 20);
            this.IntensidadEntrada.TabIndex = 67;
            // 
            // IntensidadL
            // 
            this.IntensidadL.AutoSize = true;
            this.IntensidadL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.IntensidadL.Location = new System.Drawing.Point(634, 195);
            this.IntensidadL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntensidadL.Name = "IntensidadL";
            this.IntensidadL.Size = new System.Drawing.Size(86, 20);
            this.IntensidadL.TabIndex = 66;
            this.IntensidadL.Text = "Intensidad";
            // 
            // SemanasEntrada
            // 
            this.SemanasEntrada.Location = new System.Drawing.Point(636, 271);
            this.SemanasEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.SemanasEntrada.Name = "SemanasEntrada";
            this.SemanasEntrada.Size = new System.Drawing.Size(140, 20);
            this.SemanasEntrada.TabIndex = 69;
            // 
            // SemanasL
            // 
            this.SemanasL.AutoSize = true;
            this.SemanasL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.SemanasL.Location = new System.Drawing.Point(615, 249);
            this.SemanasL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SemanasL.Name = "SemanasL";
            this.SemanasL.Size = new System.Drawing.Size(186, 20);
            this.SemanasL.TabIndex = 68;
            this.SemanasL.Text = "Lapso Tiempo (Semanas)";
            // 
            // CalentamientoL
            // 
            this.CalentamientoL.AutoSize = true;
            this.CalentamientoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.CalentamientoL.Location = new System.Drawing.Point(634, 303);
            this.CalentamientoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalentamientoL.Name = "CalentamientoL";
            this.CalentamientoL.Size = new System.Drawing.Size(118, 20);
            this.CalentamientoL.TabIndex = 70;
            this.CalentamientoL.Text = "Calentamiento";
            // 
            // DCalentamientoEntrada
            // 
            this.DCalentamientoEntrada.Location = new System.Drawing.Point(639, 439);
            this.DCalentamientoEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.DCalentamientoEntrada.Name = "DCalentamientoEntrada";
            this.DCalentamientoEntrada.Size = new System.Drawing.Size(140, 20);
            this.DCalentamientoEntrada.TabIndex = 73;
            // 
            // DCalentamientoL
            // 
            this.DCalentamientoL.AutoSize = true;
            this.DCalentamientoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DCalentamientoL.Location = new System.Drawing.Point(615, 417);
            this.DCalentamientoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DCalentamientoL.Name = "DCalentamientoL";
            this.DCalentamientoL.Size = new System.Drawing.Size(189, 20);
            this.DCalentamientoL.TabIndex = 72;
            this.DCalentamientoL.Text = "Duración Calentamiento";
            // 
            // CalentamientoEntrada
            // 
            this.CalentamientoEntrada.Location = new System.Drawing.Point(617, 336);
            this.CalentamientoEntrada.Name = "CalentamientoEntrada";
            this.CalentamientoEntrada.Size = new System.Drawing.Size(174, 67);
            this.CalentamientoEntrada.TabIndex = 74;
            this.CalentamientoEntrada.Text = "";
            // 
            // ActPEntrada
            // 
            this.ActPEntrada.Location = new System.Drawing.Point(636, 497);
            this.ActPEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.ActPEntrada.Name = "ActPEntrada";
            this.ActPEntrada.Size = new System.Drawing.Size(140, 20);
            this.ActPEntrada.TabIndex = 76;
            // 
            // ActividadPL
            // 
            this.ActividadPL.AutoSize = true;
            this.ActividadPL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.ActividadPL.Location = new System.Drawing.Point(634, 477);
            this.ActividadPL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ActividadPL.Name = "ActividadPL";
            this.ActividadPL.Size = new System.Drawing.Size(147, 20);
            this.ActividadPL.TabIndex = 75;
            this.ActividadPL.Text = "Actividad Principal";
            // 
            // DActPEntrada
            // 
            this.DActPEntrada.Location = new System.Drawing.Point(636, 560);
            this.DActPEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.DActPEntrada.Name = "DActPEntrada";
            this.DActPEntrada.Size = new System.Drawing.Size(140, 20);
            this.DActPEntrada.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(612, 538);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Duración Actividad Principal";
            // 
            // EnfriamientoEntrada
            // 
            this.EnfriamientoEntrada.Location = new System.Drawing.Point(619, 628);
            this.EnfriamientoEntrada.Name = "EnfriamientoEntrada";
            this.EnfriamientoEntrada.Size = new System.Drawing.Size(174, 67);
            this.EnfriamientoEntrada.TabIndex = 80;
            this.EnfriamientoEntrada.Text = "";
            // 
            // EnfriamientoL
            // 
            this.EnfriamientoL.AutoSize = true;
            this.EnfriamientoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.EnfriamientoL.Location = new System.Drawing.Point(636, 595);
            this.EnfriamientoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnfriamientoL.Name = "EnfriamientoL";
            this.EnfriamientoL.Size = new System.Drawing.Size(99, 20);
            this.EnfriamientoL.TabIndex = 79;
            this.EnfriamientoL.Text = "Enfriamiento";
            // 
            // DEnfriamientoEntrada
            // 
            this.DEnfriamientoEntrada.Location = new System.Drawing.Point(636, 730);
            this.DEnfriamientoEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.DEnfriamientoEntrada.Name = "DEnfriamientoEntrada";
            this.DEnfriamientoEntrada.Size = new System.Drawing.Size(140, 20);
            this.DEnfriamientoEntrada.TabIndex = 82;
            // 
            // DEnfriamientoL
            // 
            this.DEnfriamientoL.AutoSize = true;
            this.DEnfriamientoL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DEnfriamientoL.Location = new System.Drawing.Point(621, 708);
            this.DEnfriamientoL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DEnfriamientoL.Name = "DEnfriamientoL";
            this.DEnfriamientoL.Size = new System.Drawing.Size(170, 20);
            this.DEnfriamientoL.TabIndex = 81;
            this.DEnfriamientoL.Text = "Duración Enfriamiento";
            // 
            // DuracionTEntrada
            // 
            this.DuracionTEntrada.Location = new System.Drawing.Point(439, 739);
            this.DuracionTEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.DuracionTEntrada.Name = "DuracionTEntrada";
            this.DuracionTEntrada.Size = new System.Drawing.Size(140, 20);
            this.DuracionTEntrada.TabIndex = 84;
            // 
            // DuracionTL
            // 
            this.DuracionTL.AutoSize = true;
            this.DuracionTL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DuracionTL.Location = new System.Drawing.Point(426, 708);
            this.DuracionTL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DuracionTL.Name = "DuracionTL";
            this.DuracionTL.Size = new System.Drawing.Size(162, 20);
            this.DuracionTL.TabIndex = 83;
            this.DuracionTL.Text = "Duración Total Rutina";
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
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 85;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bucarToolStripMenuItem
            // 
            this.bucarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porId,
            this.porNSS,
            this.mostrarTodo});
            this.bucarToolStripMenuItem.Name = "bucarToolStripMenuItem";
            this.bucarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.bucarToolStripMenuItem.Text = "Bucar";
            // 
            // porId
            // 
            this.porId.Name = "porId";
            this.porId.Size = new System.Drawing.Size(143, 22);
            this.porId.Text = "Por ID";
            this.porId.Click += new System.EventHandler(this.porId_Click);
            // 
            // porNSS
            // 
            this.porNSS.Name = "porNSS";
            this.porNSS.Size = new System.Drawing.Size(143, 22);
            this.porNSS.Text = "Por NSS";
            this.porNSS.Click += new System.EventHandler(this.porNSS_Click);
            // 
            // mostrarTodo
            // 
            this.mostrarTodo.Name = "mostrarTodo";
            this.mostrarTodo.Size = new System.Drawing.Size(143, 22);
            this.mostrarTodo.Text = "Mostrar todo";
            this.mostrarTodo.Click += new System.EventHandler(this.mostrarTodo_Click);
            // 
            // aceptBus
            // 
            this.aceptBus.Location = new System.Drawing.Point(15, 690);
            this.aceptBus.Margin = new System.Windows.Forms.Padding(2);
            this.aceptBus.Name = "aceptBus";
            this.aceptBus.Size = new System.Drawing.Size(64, 38);
            this.aceptBus.TabIndex = 88;
            this.aceptBus.Text = "Aceptar";
            this.aceptBus.UseVisualStyleBackColor = true;
            this.aceptBus.Visible = false;
            this.aceptBus.Click += new System.EventHandler(this.aceptBus_Click);
            // 
            // datoBusEntrada
            // 
            this.datoBusEntrada.Location = new System.Drawing.Point(15, 667);
            this.datoBusEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.datoBusEntrada.Name = "datoBusEntrada";
            this.datoBusEntrada.Size = new System.Drawing.Size(140, 20);
            this.datoBusEntrada.TabIndex = 87;
            this.datoBusEntrada.Visible = false;
            // 
            // datoBuscarL
            // 
            this.datoBuscarL.AutoSize = true;
            this.datoBuscarL.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.datoBuscarL.Location = new System.Drawing.Point(12, 640);
            this.datoBuscarL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.datoBuscarL.Name = "datoBuscarL";
            this.datoBuscarL.Size = new System.Drawing.Size(119, 20);
            this.datoBuscarL.TabIndex = 86;
            this.datoBuscarL.Text = "Datos a buscar";
            this.datoBuscarL.Visible = false;
            // 
            // Rutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 788);
            this.Controls.Add(this.aceptBus);
            this.Controls.Add(this.datoBusEntrada);
            this.Controls.Add(this.datoBuscarL);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DuracionTEntrada);
            this.Controls.Add(this.DuracionTL);
            this.Controls.Add(this.DEnfriamientoEntrada);
            this.Controls.Add(this.DEnfriamientoL);
            this.Controls.Add(this.EnfriamientoEntrada);
            this.Controls.Add(this.EnfriamientoL);
            this.Controls.Add(this.DActPEntrada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActPEntrada);
            this.Controls.Add(this.ActividadPL);
            this.Controls.Add(this.CalentamientoEntrada);
            this.Controls.Add(this.DCalentamientoEntrada);
            this.Controls.Add(this.DCalentamientoL);
            this.Controls.Add(this.CalentamientoL);
            this.Controls.Add(this.SemanasEntrada);
            this.Controls.Add(this.SemanasL);
            this.Controls.Add(this.IntensidadEntrada);
            this.Controls.Add(this.IntensidadL);
            this.Controls.Add(this.NSSEntrada);
            this.Controls.Add(this.NSSL);
            this.Controls.Add(this.IDEntrada);
            this.Controls.Add(this.IDL);
            this.Controls.Add(this.datosL);
            this.Controls.Add(this.LimpiarB);
            this.Controls.Add(this.eliminarB);
            this.Controls.Add(this.ModificarB);
            this.Controls.Add(this.aceptarB);
            this.Controls.Add(this.listaRutina);
            this.Controls.Add(this.TituloPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rutina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rutina";
            this.TituloPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaRutina)).EndInit();
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
        private System.Windows.Forms.DataGridView listaRutina;
        private System.Windows.Forms.Button LimpiarB;
        private System.Windows.Forms.Button eliminarB;
        private System.Windows.Forms.Button ModificarB;
        private System.Windows.Forms.Button aceptarB;
        private System.Windows.Forms.Label datosL;
        private System.Windows.Forms.TextBox IDEntrada;
        private System.Windows.Forms.Label IDL;
        private System.Windows.Forms.TextBox NSSEntrada;
        private System.Windows.Forms.Label NSSL;
        private System.Windows.Forms.TextBox IntensidadEntrada;
        private System.Windows.Forms.Label IntensidadL;
        private System.Windows.Forms.TextBox SemanasEntrada;
        private System.Windows.Forms.Label SemanasL;
        private System.Windows.Forms.Label CalentamientoL;
        private System.Windows.Forms.TextBox DCalentamientoEntrada;
        private System.Windows.Forms.Label DCalentamientoL;
        private System.Windows.Forms.RichTextBox CalentamientoEntrada;
        private System.Windows.Forms.TextBox ActPEntrada;
        private System.Windows.Forms.Label ActividadPL;
        private System.Windows.Forms.TextBox DActPEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox EnfriamientoEntrada;
        private System.Windows.Forms.Label EnfriamientoL;
        private System.Windows.Forms.TextBox DEnfriamientoEntrada;
        private System.Windows.Forms.Label DEnfriamientoL;
        private System.Windows.Forms.TextBox DuracionTEntrada;
        private System.Windows.Forms.Label DuracionTL;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bucarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porId;
        private System.Windows.Forms.ToolStripMenuItem porNSS;
        private System.Windows.Forms.ToolStripMenuItem mostrarTodo;
        private System.Windows.Forms.Button aceptBus;
        private System.Windows.Forms.TextBox datoBusEntrada;
        private System.Windows.Forms.Label datoBuscarL;
    }
}