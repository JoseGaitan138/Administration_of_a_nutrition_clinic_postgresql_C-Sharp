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
    public partial class Alimento : Form
    {
        NpgsqlConnection conn2;
        DataTable tabla;
        string desayuno, comida, cena, colasion1, colasion2;
        int caloriasTotales;
        int bandera;
        public Alimento(NpgsqlConnection conn)
        {
            InitializeComponent();
            conn2 = new NpgsqlConnection();
            conn2 = conn;
            caloriasTotales = 0;
            desayuno = "";
            comida = "";
            cena = "";
            colasion1 = "";
            colasion2 = "";
            labelInfoComida.Text = "Desayuno";
            bandera = 0;
            btnAgregarMenu.Enabled = false;
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        void mostrar(string linea)
        {
            
            try
            {
                conn2.Open();
                DataSet datos = new DataSet();
                
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(linea, conn2);
                add.Fill(datos);
                datos.Tables[0].Columns[0].ColumnName = "Nombre";
                datos.Tables[0].Columns[1].ColumnName = "Ración";
                datos.Tables[0].Columns[2].ColumnName = "Calorias";
                datos.Tables[0].Columns[3].ColumnName = "Grupo";
                dataGridView1.DataSource = datos.Tables[0];
                conn2.Close();
            }
            catch
            {
                MessageBox.Show("Error al hacer la busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void VerdurasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 1;");
        }

        private void FrutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 2;");
        }

        private void CerealesYTuberculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 3;");
        }

        private void LeguminosasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 4;");
        }

        private void AlimentosDeOrigenAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 5;");
        }

        private void LacteosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 6;");
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if(bandera == 0)
            {
                bandera++;
                labelInfoComida.Text = "Colasion";
            }
            else if(bandera == 1)
            {
                bandera++;
                labelInfoComida.Text = "Comida";
            }
            else if(bandera == 2)
            {
                bandera++;
                labelInfoComida.Text = "Colasion";
            }
            else if(bandera == 3)
            {
                bandera++;
                labelInfoComida.Text = "Cena";
                
            }
            else if(bandera == 4)
            {
                btnAgregarMenu.Enabled = true;
                btnAceptar.Enabled = false;
                btnFinalizar.Enabled = false;

            }
        }

        private void BtnAgregarMenu_Click(object sender, EventArgs e)
        {
            string linea;
            try
            {
                conn2.Open();
                linea = "INSERT INTO Dieta (Desayuno,Primer_refrigerio,Comida,Segundo_refrigerio,Cena,Kilocalorias_Totales)" +
                    " VALUES ('" + desayuno + "','" + colasion1 + "','" + comida + "','" + colasion2 + "','" + cena +
                    "','" + caloriasTotales.ToString() + "');";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();

                conn2.Close();
            }
            catch(NpgsqlException ex)
            {
                conn2.Close();
                MessageBox.Show(ex.Message);
            }

            try
            {
                conn2.Open();
                string count = "SELECT COUNT(*) FROM Dieta;";
                NpgsqlDataAdapter add = new NpgsqlDataAdapter(count, conn2);


                DataSet datos = new DataSet();
                add.Fill(datos);

                linea = "INSERT INTO Menu (NSS_Afiliado," + "ID_Dieta" + ") VALUES " +
                    "('" + textBox1.Text + "'," + datos.Tables[0].Rows[0][0].ToString() + ");";
                NpgsqlCommand command = new NpgsqlCommand(linea, conn2);
                command.ExecuteNonQuery();
                MessageBox.Show("Menu agregado");
                conn2.Close();
            }
            catch (NpgsqlException ex)
            {
                conn2.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                labelNss.Visible = false;
                textBox1.Visible = false;
                textBox1.Enabled = false;
                labelGrupo.Visible = true;
                labelGrupo.Enabled = true;

                labelCalorias.Visible = true;
                labelCalorias.Enabled = true;

                labelCaloriasTotales.Visible = true;
                labelCaloriasTotales.Enabled = true;

                labelCaloriasTotalesCant.Visible = true;
                labelCaloriasTotalesCant.Enabled = true;

                labelCantCalorias.Visible = true;
                labelCantCalorias.Enabled = true;

                labelCantRacion.Visible = true;
                labelCantRacion.Enabled = true;

                labelRacion.Visible = true;
                labelRacion.Enabled = true;

                labelGrupoAlimentacionNombre.Visible = true;
                labelGrupoAlimentacionNombre.Enabled = true;

                labelNombre.Visible = true;
                labelNombre.Enabled = true;

                labelNombreAlimento.Visible = true;
                labelNombreAlimento.Enabled = true;

                labelInfoComida.Visible = true;
                labelInfoComida.Enabled = true;

                dataGridView1.Visible = true;
                dataGridView1.Enabled = true;
                btnAceptar.Visible = true;
                btnAceptar.Enabled = true;
                btnFinalizar.Visible = true;
                btnFinalizar.Enabled = true;
                btnAgregarMenu.Visible = true;
            }
        }

        private void AceitesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrar("select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio where Grupo_alimenticio = 7;");
        }

        private void MostrarTodo_Click(object sender, EventArgs e)
        {
            string linea = "select alimento.Nombre,Racion,Calorias,grupo_alimentos.Nombre from alimento INNER JOIN grupo_alimentos ON " +
                "grupo_alimentos.Id = alimento.Grupo_alimenticio;";
            mostrar(linea);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.CurrentRow;
            labelNombreAlimento.Text = Convert.ToString(fila.Cells[0].Value);
            labelCantRacion.Text = Convert.ToString(fila.Cells[1].Value);
            labelCantCalorias.Text = Convert.ToString(fila.Cells[2].Value);
            labelGrupoAlimentacionNombre.Text = Convert.ToString(fila.Cells[3].Value);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                caloriasTotales += Convert.ToInt32(labelCantCalorias.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione una casilla");
            }
            
            if(bandera == 0)
            {
                desayuno += labelNombreAlimento.Text;
            }
            else if(bandera == 1)
            {
                colasion1 += labelNombreAlimento.Text;
            }
            else if(bandera == 2)
            {
                comida += labelNombreAlimento.Text;
            }
            else if(bandera == 3)
            {
                colasion2 += labelNombreAlimento.Text;
            }
            else if(bandera == 4)
            {
                cena += labelNombreAlimento.Text;
            }
            labelCaloriasTotalesCant.Text = caloriasTotales.ToString();
            labelNombreAlimento.Text = "";
            labelCantRacion.Text = "";
            labelCantCalorias.Text = "";
            labelGrupoAlimentacionNombre.Text = "";

        }
    }
}

