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

namespace InsumosMedicos
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\logo.png");
            this.BackgroundImage = img;;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
        private void Log()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM clientes WHERE usuario= '" + user_txt.Text + "'AND psw = '" + psw_txt.Text + "' ";
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
        private void LogVendedor()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM vendedores WHERE usuario= '" + user_txt.Text + "'AND psw = '" + psw_txt.Text + "' ";
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

        private void button1_Click(object sender, EventArgs e)
        {
            Log();
            LogVendedor();
        }

        private void Regist_clic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }
    }
}
