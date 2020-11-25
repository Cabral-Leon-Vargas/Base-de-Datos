using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
namespace InsumosMedicos
{
    public partial class Registro : Form
    {
        public static string Usuario = "";
        

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
            string query = "insert into clientes(`ID`,`nombre`,`apellido`,`numero de contacto`,`direccion`,`hospital`,`usuario`, `psw`) VALUES (NULL,'"+ reg_name_txt.Text + "','" + reg_ape_txt.Text + "','" + reg_cell_txt.Text + "','" + reg_direc_txt.Text + "','" + reg_hosp_txt.Text + "','" + reg_user_txt.Text + "', SHA1('"+reg_psw_txt.Text+"'))";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Registro Exitoso \n Cierre esta ventana e inicie sesión", "HECHO");
                reg_psw_txt.Text = "";
                reg_hosp_txt.Text = "";
                reg_cell_txt.Text = "";
                reg_ape_txt.Text = "";
                reg_direc_txt.Text = "";
                reg_name_txt.Text = "";
                reg_user_txt.Text = "";
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
            string query = "insert into vendedores(`ID`,`nombre`,`apellido`,`numero de contacto`,`direccion`,`usuario`, `psw`) VALUES (NULL,'" + reg_name_txt.Text + "','" + reg_ape_txt.Text + "','" + reg_cell_txt.Text + "','" + reg_direc_txt.Text + "','" + reg_user_txt.Text + "',  SHA1('"+reg_psw_txt.Text+"') )";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Registro Exitoso \n Cierre esta ventana e inicie sesión", "HECHO");
                reg_psw_txt.Text = "";
                reg_hosp_txt.Text = "";
                reg_cell_txt.Text = "";
                reg_ape_txt.Text = "";
                reg_direc_txt.Text = "";
                reg_name_txt.Text = "";
                reg_user_txt.Text = "";
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


        private void CrearVendedor_btn_Click(object sender, EventArgs e)
        {
            if (Usuario == "Cliente")
            {
                RegCliente();
                vendedor.Enabled = false;

            }
            else if (Usuario == "Vendedor")
            {
                RegVendedor();
            }
            else
            {
                MessageBox.Show("Seleccione una de las casillas", "ERROR");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (vendedor.Checked==true)
            { 
               Usuario = "Vendedor";
               cliente.Enabled = false;
            }
            else
            {
               cliente.Enabled=true;
                Usuario = "";
            }

        }

        private void cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (cliente.Checked==true)
            { 
               Usuario = "Cliente";
               vendedor.Enabled = false;
            }
            else
            {
                Usuario = "";
               vendedor.Enabled=true;
            }
            
        }

        private void check_psw_CheckedChanged(object sender, EventArgs e)
        {
            if (check_psw.Checked == true)
            {
                reg_psw_txt.UseSystemPasswordChar = false;
            }
            else
            {
                reg_psw_txt.UseSystemPasswordChar = true;
            }
        }
    }
}
