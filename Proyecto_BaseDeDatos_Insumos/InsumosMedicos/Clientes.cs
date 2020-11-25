using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsumosMedicos
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vendedores_contacto select = new Vendedores_contacto();
            select.Show();
        }

        private void Ariticulos_btn_Click(object sender, EventArgs e)
        {
            Productos_cliente select = new Productos_cliente();
            select.Show();
        }
    }
}
