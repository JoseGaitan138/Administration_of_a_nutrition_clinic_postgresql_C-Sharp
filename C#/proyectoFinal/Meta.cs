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
    public partial class Meta : Form
    {
        NpgsqlConnection conn2;
        public Meta(NpgsqlConnection conn)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
        }
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        void limpiar()
        {
            NSSEntada.Clear();
            circunferenciaEntrada.Clear();
            pesoIniEntrada.Clear();
            fechaIniEntrada.Clear();
            FechaConEntrada.Clear();
            pesoMetaEntrada.Clear();
        }

        private void AceptarB_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string dato = "insert into Meta_Perdida_peso(NSS_Afiliado, Circunferencia, Peso_Inicial, Fecha_Inicio, Fecha_Final, Peso_Meta)" +
                    " values (" + NSSEntada.Text + "," + circunferenciaEntrada.Text + "," + pesoIniEntrada.Text + ",'" + fechaIniEntrada.Text + "','" + FechaConEntrada.Text + "'," + pesoMetaEntrada.Text + ");";
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Meta agregada con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch
            {
                MessageBox.Show("Error al agregar la meta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaMetas.CurrentRow;
            try
            {
                conn2.Open();
                string linea = "update Meta_Perdida_peso set NSS_Afiliado =" + NSSEntada.Text + ",Circunferencia=" + circunferenciaEntrada.Text + ",Peso_Inicial=" + pesoIniEntrada.Text + ",Fecha_Inicio='" + fechaIniEntrada.Text + "',Fecha_Final='" + FechaConEntrada.Text + "',Peso_Meta=" + pesoMetaEntrada.Text + "where ID_Meta=" + fila.Cells[0].Value + ";";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Meta modificada con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch(NpgsqlException ex)
            {
                conn2.Close();
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Error al modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaMetas.CurrentRow;
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from Meta_Perdida_peso where ID_Meta =" + fila.Cells[0].Value + ";", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Meta eliminada con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch
            {
                MessageBox.Show("Error al eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        void mostrar(string linea)
        {
            
            try
            {
                conn2.Open();
                DataSet datos = new DataSet();
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(linea, conn2);
                add.Fill(datos);
                listaMetas.DataSource = datos.Tables[0];
                conn2.Close();
            }
            catch
            {
                MessageBox.Show("Error al hacer la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
            datoBusEntrada.Clear();
        }

        private void AceptBus_Click(object sender, EventArgs e)
        {
            mostrarPor();
        }

        private void PorNSS_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "NSS a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            mostrar("Select * from Meta_Perdida_peso;");
        }

        private void mostrarPor()
        {
            
            if (datoBuscarL.Text == "ID a buscar")
                mostrar("Select * from Meta_Perdida_peso where ID_Meta=" + datoBusEntrada.Text );
            else if (datoBuscarL.Text == "NSS a buscar")
                mostrar("Select * from Meta_Perdida_peso where NSS_Afiliado=" + datoBusEntrada.Text );

        }

        private void PorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void ListaMetas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = listaMetas.CurrentRow;
            NSSEntada.Text = Convert.ToString(fila.Cells[1].Value);
            circunferenciaEntrada.Text = Convert.ToString(fila.Cells[2].Value);
            pesoIniEntrada.Text = Convert.ToString(fila.Cells[3].Value);
            fechaIniEntrada.Text = Convert.ToString(fila.Cells[4].Value);
            FechaConEntrada.Text = Convert.ToString(fila.Cells[5].Value);
            pesoMetaEntrada.Text = Convert.ToString(fila.Cells[6].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
