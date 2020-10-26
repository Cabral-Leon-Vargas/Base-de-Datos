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
        //aqui va la parte del codigo
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
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else if (reg_psw_txt.Text == "")
            {
                MessageBox.Show("Falta llenar uno o más campos");
            }
            else 
            {
              // aqui va "Reg();"
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
