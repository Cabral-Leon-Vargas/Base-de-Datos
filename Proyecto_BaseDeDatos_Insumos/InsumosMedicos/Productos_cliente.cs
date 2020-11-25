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
    public partial class Productos_cliente : Form
    {
        
        public Productos_cliente()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\logo.png");
            this.BackgroundImage = img; ;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Productos_cliente_Load(object sender, EventArgs e)
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

                        Console.WriteLine(reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " ");
                        string[] row = { reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Existen el Articulo");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
