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
    public partial class Rutina : Form
    {
        NpgsqlConnection connection;
        public Rutina(NpgsqlConnection connection)
        {
            InitializeComponent();
            this.connection = new NpgsqlConnection();
            this.connection = connection;
            DuracionTEntrada.Enabled = false;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void limpiar()
        {
            IDEntrada.Clear();
            NSSEntrada.Clear();
            IntensidadEntrada.Clear();
            SemanasEntrada.Clear();
            CalentamientoEntrada.Clear();
            DCalentamientoEntrada.Clear();
            ActPEntrada.Clear();
            DActPEntrada.Clear();
            EnfriamientoEntrada.Clear();
            DEnfriamientoEntrada.Clear();
            DuracionTEntrada.Clear();
        }

        private void LimpiarB_Click(object sender, EventArgs e)
        {
            limpiar();
            datoBusEntrada.Clear();
        }

        private void aceptarB_Click(object sender, EventArgs e)
        {
            int total = 0;
            total += Convert.ToInt32(DCalentamientoEntrada.Text);
            total += Convert.ToInt32(DActPEntrada.Text);
            total += Convert.ToInt32(DEnfriamientoEntrada.Text);

            try
            {
                connection.Open();
                string dato = "insert into rutina(ID_Rutina, Intensidad, Semanas, Calentamiento, Duracion_Calentamiento, Actividad_Principal, Duracion_Actividad_Principal, Enfriamiento, Duracion_Enfriamiento, Duracion_Total)" +
                    " values('" + IDEntrada.Text + "','"+ IntensidadEntrada.Text + "','" + SemanasEntrada.Text + "','" + CalentamientoEntrada.Text + "','"
                    + DCalentamientoEntrada.Text + "','" + ActPEntrada.Text + "','" + DActPEntrada.Text + "','"
                    + EnfriamientoEntrada.Text + "','" + DEnfriamientoEntrada.Text + "','" + total.ToString() + "');";
                //MessageBox.Show(dato);
                NpgsqlCommand command = new NpgsqlCommand(dato, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Rutina agredada con exito");
                connection.Close();
                limpiar();
            }

            catch(NpgsqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                connection.Close();
                MessageBox.Show("Error al agregar la rutina", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        }

        private void eliminarB_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = listaRutina.CurrentRow;
            try
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("delete from Rutina where ID_Rutina ='" + fila.Cells[0].Value + "';", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Rutina eliminada con exito");
                connection.Close();
                limpiar();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Error al eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ModificarB_Click(object sender, EventArgs e)
        {
            int total = 0;
            total += Convert.ToInt32(DCalentamientoEntrada.Text);
            total += Convert.ToInt32(DActPEntrada.Text);
            total += Convert.ToInt32(DEnfriamientoEntrada.Text);
            DataGridViewRow fila = listaRutina.CurrentRow;
            try
            {
                connection.Open();
                string linea = "update Rutina set NSS_Afiliado='" + NSSEntrada.Text + "',Intensidad='" + IntensidadEntrada.Text + "',Semanas='" + SemanasEntrada.Text + "',Calentamiento='" + CalentamientoEntrada.Text 
                    + "',Duracion_Calentamiento='" + DCalentamientoEntrada.Text + "',Actividad_Principal='" + ActPEntrada.Text + "',Duracion_Actividad_Principal='" + DActPEntrada.Text
                    + "',Enfriamiento='" + EnfriamientoEntrada.Text + "',Duracion_Enfriamiento='" + DEnfriamientoEntrada.Text + "',Duracion_Total='" + total.ToString() + "' where ID_Rutina='" + fila.Cells[0].Value + "';";
                NpgsqlCommand command = new NpgsqlCommand(linea, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Rutina modificado con exito");
                connection.Close();
                limpiar();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Error al modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void porId_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "ID a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void porNSS_Click(object sender, EventArgs e)
        {
            datoBuscarL.Text = "NSS a buscar";
            datoBuscarL.Visible = true;
            datoBusEntrada.Visible = true;
            aceptBus.Visible = true;
        }

        private void mostrarTodo_Click(object sender, EventArgs e)
        {
            mostrar("Select * from Rutina;");
        }

        private void mostrarPor()
        {
            
            if (datoBuscarL.Text == "ID a buscar")
                mostrar("Select * from Rutina where ID_Rutina='" + datoBusEntrada.Text + "'");
            else if (datoBuscarL.Text == "NSS a buscar")
                mostrar("Select * from Rutina where NSS_Afiliado='" + datoBusEntrada.Text + "'");
            else
                mostrar("Select * from Rutina;");
        }

        void mostrar(string linea)
        {
            try
            {
                connection.Open();
                DataSet datos = new DataSet();
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(linea, connection);
                add.Fill(datos);
                listaRutina.DataSource = datos.Tables[0];
                connection.Close();
            }
            catch
            {
                connection.Close();
                MessageBox.Show("Error al hacer la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void aceptBus_Click(object sender, EventArgs e)
        {
            mostrarPor();
        }

        private void listaRutina_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = listaRutina.CurrentRow;
            IDEntrada.Text = Convert.ToString(fila.Cells[0].Value);
            NSSEntrada.Text = Convert.ToString(fila.Cells[1].Value);
            IntensidadEntrada.Text = Convert.ToString(fila.Cells[2].Value);
            SemanasEntrada.Text = Convert.ToString(fila.Cells[3].Value);
            CalentamientoEntrada.Text = Convert.ToString(fila.Cells[4].Value);
            DCalentamientoEntrada.Text = Convert.ToString(fila.Cells[5].Value);
            ActPEntrada.Text = Convert.ToString(fila.Cells[6].Value);
            DActPEntrada.Text = Convert.ToString(fila.Cells[7].Value);
            EnfriamientoEntrada.Text = Convert.ToString(fila.Cells[8].Value);
            DEnfriamientoEntrada.Text = Convert.ToString(fila.Cells[9].Value);
            DuracionTEntrada.Text = Convert.ToString(fila.Cells[10].Value);
        }
    }
}
