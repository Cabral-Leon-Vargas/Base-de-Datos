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
    public partial class productos_vendedores : Form
    {
        public productos_vendedores()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\logo.png");
            this.BackgroundImage = img; ;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void productos_vendedores_Load(object sender, EventArgs e)
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM `insumos`";
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

                        Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " );
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Existen el Articulo", "¡AVISO!");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GuardarProducto()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "insert into `insumos`(`serie`, `producto`, `descripcion`, `precio`) VALUES (NULL, '" + Producto_txt.Text + "', '" + Descripcion_txt.Text + "', '" + Precio_txt.Text + "')";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Artículo Registrado", "HECHO");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ModificarProducto()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "UPDATE `insumos` SET `producto`='" + Producto_txt.Text + "',`descripcion`='" + Descripcion_txt.Text + "',`precio`='" + Precio_txt.Text + "' WHERE serie = '" + Serie_txt.Text + "' ";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Se actualizó correctamente el artículo", "HECHO");
                conectionDatabase.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void BorrarProducto()
        {
            string connection = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "DELETE  FROM `insumos`  WHERE serie ='" + Serie_txt.Text + "'";
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;

            try
            {
                conectionDatabase.Open();
                MySqlDataReader reader1 = databaseCommand.ExecuteReader();
                MessageBox.Show("Se Eliminó el Artículo", "HECHO");
                conectionDatabase.Close();

                Producto_txt.Text = "";
                Precio_txt.Text = "";
                Descripcion_txt.Text = "";
                Serie_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarProducto()
        {
            string Connect = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM `insumos`";
            MySqlConnection databaseConnection = new MySqlConnection (Connect);
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
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var ListViewItems = new ListViewItem(row);
                        listView1.Items.Add(ListViewItems);
                    }

                }
                else
                {
                    Console.WriteLine("No se encontró el Artículo");
                }
                databaseConnection.Close();
                Producto_txt.Text = "";
                Descripcion_txt.Text = "";
                Precio_txt.Text = "";
                Serie_txt.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void BuscarProducto()
        {
            string Connect = "datasource=localhost;port=3306;username=MarcoJeanLT;password=Mjean2*2=4;database=ventas;";
            string query = "SELECT * FROM `insumos` WHERE serie = '" + Serie_txt.Text + "' ";
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
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)};
                        Producto_txt.Text = row[1];
                        Descripcion_txt.Text = row[2];
                        Precio_txt.Text = row[3];
                    }

                }
                else
                {
                    Console.WriteLine("No se encontró el Artículo", "¡AVISO!");
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Producto_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Descripcion_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Precio_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Serie_txt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Producto_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos", "ERROR");
            }
            else if (Descripcion_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos", "ERROR");
            }
            else if (Precio_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos", "ERROR");
            }
            else
            {

                GuardarProducto();
                MostrarProducto();

                Producto_txt.Text = "";
                Descripcion_txt.Text = "";
                Precio_txt.Text = "";

            }

        }

        private void Ref_btn_Click(object sender, EventArgs e)
        {
            MostrarProducto();

        }

        private void Clean_btn_Click(object sender, EventArgs e)
        {
            Producto_txt.Text = "";
            Descripcion_txt.Text = "";
            Precio_txt.Text = "";
            Serie_txt.Text = "";

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            BorrarProducto();
            MostrarProducto();

        }

        private void Mod_btn_Click(object sender, EventArgs e)
        {
            ModificarProducto();
            if (Producto_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos", "ERROR");
            }
            else if (Descripcion_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos", "ERROR");
            }
            else if (Precio_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos", "ERROR");
            }
            else
            {
                Producto_txt.Text = "";
                Descripcion_txt.Text = "";
                Precio_txt.Text = "";
                MostrarProducto();
            }

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}




 
