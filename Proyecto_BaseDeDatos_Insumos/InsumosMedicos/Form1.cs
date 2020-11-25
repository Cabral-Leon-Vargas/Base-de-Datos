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
        public static string TipoCuenta = "";


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
        private void LogCliente()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM clientes WHERE usuario= '" + user_txt.Text + "'AND psw = SHA1('" + psw_txt.Text + "')";
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
                    Clientes cliente = new Clientes();
                    cliente.Show();
                    user_txt.Text = "";
                    psw_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos. Intentelo de nuevo", "ERROR");
                }
                conectionDatabase.Close();
                

            }
            catch 
            {
                MessageBox.Show("Intentelo de nuevo");
            }
        }
        private void LogVendedor()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM vendedores WHERE usuario= '" + user_txt.Text + "'AND psw = SHA1('"+ psw_txt.Text +"')";
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
                    productos_vendedores vendedor = new productos_vendedores();
                    vendedor.Show();
                    user_txt.Text = "";
                    psw_txt.Text = "";
                }
                else
                {
                    MessageBox.Show("Usuario/Contraseña incorrectos. Intentelo de nuevo", "ERROR");
                }
                conectionDatabase.Close();
                

            }
            catch 
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
            if (TipoCuenta == "Vendedor")
            {
                LogVendedor();
            }
            else if (TipoCuenta == "cliente")
            {
                LogCliente();
            }
            else
            {
                MessageBox.Show("Seleccione una de las casillas", "ERROR");
            }


        }

        private void Regist_clic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
        }



        private void check_psw_CheckedChanged(object sender, EventArgs e)
        {
            if (check_psw.Checked==true)
            {
                psw_txt.UseSystemPasswordChar = false;
            }
            else
            {
                psw_txt.UseSystemPasswordChar = true;
            }

        }

        private void check_Vendedor_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Vendedor.Checked == true)
            {
                TipoCuenta = "Vendedor";
                check_cliente.Enabled = false;
            }
            else
            {
                check_cliente.Enabled = true;
                TipoCuenta = "";
            }
        }

        private void check_cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (check_cliente.Checked == true )
            {
                TipoCuenta = "cliente";
                check_Vendedor.Enabled = false;
            }
            else
            {
                check_Vendedor.Enabled = true;
                TipoCuenta = "";
            }

        }
    }
}
