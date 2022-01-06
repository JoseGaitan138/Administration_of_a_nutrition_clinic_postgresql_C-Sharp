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
    public partial class Afiliado : Form
    {
        NpgsqlConnection conn2;
        public Afiliado(NpgsqlConnection conn)
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
            nombreEntrada.Clear();
            fechaEntrada.Clear();
            sexoEntrada.Clear();
            edadEntrada.Clear();
            pesoEntrada.Clear();
            alturaEntrada.Clear();
            enfermedadesEntrada.Clear();
            MasaEntrada.Clear();
        }

        private void AceptarB_Click(object sender, EventArgs e)
        {
            try
            {
                conn2.Open();
                string dato = "insert into afiliado values('" + NSSEntada.Text + "','" + nombreEntrada.Text + "','" + fechaEntrada.Text + "','" + sexoEntrada.Text +
                    "','" + edadEntrada.Text + "','" + pesoEntrada.Text + "','" + alturaEntrada.Text + "','" + MasaEntrada.Text + "','" + enfermedadesEntrada.Text + "');";
                //MessageBox.Show(dato);
                NpgsqlCommand command = new NpgsqlCommand(dato, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Afiliado agredado con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }

            catch(NpgsqlException ex)
            {
                conn2.Close();
                MessageBox.Show("Error al agregar el Afiliado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
            datoBusEntrada.Clear();
        }

        private void EliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            try
            {
                conn2.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from Afiliado where NSS_Afiliado ='" + fila.Cells[0].Value + "';", conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Afiliado eliminado con exito");
                conn2.Close();
                mostrarPor();
                limpiar();
            }
            catch
            {
                conn2.Close();
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
                listaAlmacen.DataSource = datos.Tables[0];
                conn2.Close();
            }
            catch
            {
                conn2.Close();
                MessageBox.Show("Error al hacer la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        

        
        
        private void PorId_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "NSS a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void PorModelo_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "Nombre a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void Todo_Click(object sender, EventArgs e)
        {
            mostrar("Select * from Afiliado;");
        }

        private void AceptBus_Click(object sender, EventArgs e)
        {
            mostrarPor();
        }

        private void mostrarPor()
        {
            if (datoBuscarL.Text == "NSS a buscar")
                mostrar("Select * from Afiliado where NSS_Afiliado='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "Nombre a buscar")
                mostrar("Select * from Afiliado where Nombre_Afiliado='" + datoBusEntrada.Text + "'");
            else
                mostrar("Select * from Afiliado;");
        }

        private void ListaAlmacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            NSSEntada.Text = Convert.ToString(fila.Cells[0].Value);
            nombreEntrada.Text = Convert.ToString(fila.Cells[1].Value);
            fechaEntrada.Text = Convert.ToString(fila.Cells[2].Value);
            sexoEntrada.Text = Convert.ToString(fila.Cells[3].Value);
            edadEntrada.Text = Convert.ToString(fila.Cells[4].Value);
            pesoEntrada.Text = Convert.ToString(fila.Cells[5].Value);
            alturaEntrada.Text = Convert.ToString(fila.Cells[6].Value);
            MasaEntrada.Text = Convert.ToString(fila.Cells[7].Value);
            enfermedadesEntrada.Text = Convert.ToString(fila.Cells[8].Value);
        }

        

        private void ModificarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaAlmacen.CurrentRow;
            try
            {
                conn2.Open();
                string linea = "update Afiliado set Nombre_Afiliado='" + nombreEntrada.Text + "',Fecha_Nacimiento='" + fechaEntrada.Text + "',Sexo='" + sexoEntrada.Text +
                    "',Edad='" + edadEntrada.Text + "',Peso='" + pesoEntrada.Text + "',Altura='" + alturaEntrada.Text + "',Indice_Masa='" + MasaEntrada.Text + "',Enfermedad='" + enfermedadesEntrada.Text + "' where NSS_Afiliado='" + fila.Cells[0].Value + "';";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Afiliado modificado con exito");
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


        }
    }
