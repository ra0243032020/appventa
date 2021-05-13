using appventas.DAO;
using appventas.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsAcceso acces = new ClsAcceso();

            int valor = acces.acceso(txtUsuario.Text,txtPassword.Text);

            if (valor==1) {

                FrmVenta venta = new FrmVenta();
                venta.Show();
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
