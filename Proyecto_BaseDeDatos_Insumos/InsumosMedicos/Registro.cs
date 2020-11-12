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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\logo.png");
            this.BackgroundImage = img; ;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void RegCliente()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "insert into clientes(`ID`,`nombre`,`apellido`,`numero de contacto`,`direccion`,`hospital`,`usuario`, `psw`) VALUES (NULL,'" + reg_name_txt.Text + "','" + reg_ape_txt.Text + "','" + reg_cell_txt.Text + "','" + reg_direc_txt.Text + "','" + reg_hosp_txt.Text + "','" + reg_user_txt.Text + "', '" + reg_psw_txt.Text + "')";
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
        private void RegVendedor()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "insert into vendedores(`ID`,`nombre`,`apellido`,`numero de contacto`,`direccion`,`usuario`, `psw`) VALUES (NULL,'" + reg_name_txt.Text + "','" + reg_ape_txt.Text + "','" + reg_cell_txt.Text + "','" + reg_direc_txt.Text + "','" + reg_user_txt.Text + "', '" + reg_psw_txt.Text + "')";
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

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void reg_user_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_psw_txt_TextChanged(object sender, EventArgs e)
        {

        }


        private void reg_name_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_cell_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_ape_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_direc_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_hosp_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void crear_btn_Click(object sender, EventArgs e)
        {
            RegCliente();
        }

        private void CrearVendedor_btn_Click(object sender, EventArgs e)
        {
            RegVendedor();
        }
    }
}
