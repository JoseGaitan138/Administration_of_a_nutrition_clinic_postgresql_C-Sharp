using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace proyectoFinal
{
    public partial class Form1 : Form
    {

        NpgsqlConnection conn;
        public Form1()
        {
            InitializeComponent();
        }



        private void AgregarBoton_Click(object sender, EventArgs e)
        {
            bool bandera = true;
            string parametro = "Server=localhost;Port=5432;"+"User id="+usuarioEntrada.Text+";"+"Password ="+contraseñaEntrada.Text+";"+ "Database = postgres; ";
            conn = new NpgsqlConnection();
            conn.ConnectionString = parametro;

            try
            {
                conn.Open();
            }

            catch
            {
                MessageBox.Show("Error al conectar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                bandera = false;
            }

            conn.Close();

            if (bandera)
            {
                MenuPrincipal menu = new MenuPrincipal(conn);
                menu.Show();
                this.Visible = false;
            }
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }

        
}

