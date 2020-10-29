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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Reg()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=login;";
            string query = "insert into log(`ID`,`usuario`, `contraseña`) VALUES (NULL,'" + reg_user_txt.Text + "', '" + reg_psw_txt.Text + "')";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Registro Exitoso \n Cierre esta ventana e inicie sesión", "HECHO");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void registro_Load(object sender, EventArgs e)
        {
        }

        private void reg_user_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_psw_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void crear_btn_Click(object sender, EventArgs e)
        {
            if (reg_user_txt.Text == "")
            {
                MessageBox.Show("Falta llenar un campo", "ERROR");
            }
            else if (reg_psw_txt.Text == "")
            {
                MessageBox.Show("Falta llenar un campo", "ERROR");
            }
            else if (reg_user_txt.Text == "" && reg_psw_txt.Text == "") 
            {
                 MessageBox.Show("TODOS LOS CAMPOS ESTAN VACIOS", "ERROR");
            }
            else
            {
                Reg();
            }
        }

        private void reg_Click(object sender, EventArgs e)
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
