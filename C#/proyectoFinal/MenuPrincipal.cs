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
    public partial class MenuPrincipal : Form
    {
        NpgsqlConnection conn2;
        public MenuPrincipal(NpgsqlConnection conn)
        {
            
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
        }

   
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ProductoBotton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Afiliado afiliado = new Afiliado(conn2);
            afiliado.MdiParent = this;
            afiliado.Show();
        }

        private void ProductoBotton_MouseEnter(object sender, EventArgs e)
        {
            productoBotton.BackColor = Color.AliceBlue;
        }

        private void ProductoBotton_MouseLeave(object sender, EventArgs e)
        {
            productoBotton.BackColor = Color.RoyalBlue;
        }

        private void buttonRutina_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Rutina rutina = new Rutina(conn2);
            rutina.MdiParent = this;
            rutina.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Meta meta = new Meta(conn2);
            meta.MdiParent = this;
            meta.Show();
        }

        private void BtnAlimentos_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Alimento alimento = new Alimento(conn2);
            alimento.MdiParent = this;
            alimento.Show();
        }
    }
        
}
