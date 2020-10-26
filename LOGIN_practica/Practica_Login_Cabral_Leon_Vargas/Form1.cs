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

namespace Practica_Login_Cabral_Leon_Vargas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Log()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=login;";
            string query = "SELECT * FROM log WHERE usuario= '" + user_txt.Text + "'AND contraseña = '" + psw_txt.Text + "' ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Bienvenido " + user_txt.Text, "Entrada Exitosa");
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos. Intentelo de nuevo", "ERROR");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Intentelo de nuevo");
            }

        }
        private void user_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void psw_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            Log();
        }

        private void Regist_clic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registro = new Form2();
            registro.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
