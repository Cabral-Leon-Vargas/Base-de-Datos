using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaseDeDatos_Cabral_Leon_Vargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=datospersonales;";
            string query = "SELECT * FROM `datos personales`";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5));
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)};
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Existen Datos");
                }
                conectionDatabase.Close();

                }
                catch (Exception ex)
               {
                MessageBox.Show(ex.Message);
               }
        }
        private void GuardarUsuario()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=datospersonales;";
            string query = "insert into `datos personales`(`ID`, `Nombre(s)`, `Apellido Paterno`, `Apellido Materno`, `Edad`, `Direccion`) VALUES (NULL, '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Registro Exitoso");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }
        private void ModificarUsuario()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=datospersonales;";
            string query = "UPDATE `datos personales` SET `Nombre(s)`='" + textBox1.Text + "',`Apellido Paterno`='" + textBox2.Text + "',`Apellido Materno`='" + textBox3.Text + "',`Edad`='" + textBox4.Text + "',`Direccion`='" + textBox5.Text + "' WHERE ID = '" + textBox6.Text + "' ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Se actualizron correctamente los Datos");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void BorrarUsuario()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=datospersonales;";
            string query = "DELETE  FROM `datos personales`  WHERE ID ='" + textBox6.Text +"'";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Se Eliminó el Registro");
                conectionDatabase.Close();
                
                textBox1.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox6.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void MostrarUsuario()
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }

        }
        private void Buscar()
        {
            string Connect = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=datospersonales;";
            string query = "SELECT * FROM `datos personales` WHERE ID = '"+ textBox6.Text + "' ";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    listView1.Items.Clear();
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        textBox1.Text = row[1];
                        textBox2.Text = row[2];
                        textBox3.Text = row[3];
                        textBox4.Text = row[4];
                        textBox5.Text = row[5];
                    }

                }
                else
                {
                    Console.WriteLine("No se encontraron los Datos");
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

      
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Falta llenar uno o más campos");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Falta llenar uno o más campos");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Falta llenar uno o más campos");
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Falta llenar uno o más campos");
                }
                else if (textBox5.Text == "")
                {
                    MessageBox.Show("Falta llenar uno o más campos");
                }
                else
                {

                    GuardarUsuario();
                    MostrarUsuario();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                }

            }

            private void button2_Click_1(object sender, EventArgs e)
        {
            Buscar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            MostrarUsuario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarUsuario();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorrarUsuario();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
   
}

