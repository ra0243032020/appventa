using appventas.DAO;
using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appventas.VISTA
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

            ClsDCliente clscliente = new ClsDCliente();


                comboBox2.DataSource = clscliente.CargarComboCliente();
                comboBox2.DisplayMember = "nombreCliente";
                comboBox2.ValueMember = "iDCliente";

            ClsDDocumento clsDDocumento = new ClsDDocumento();   

                comboBox1.DataSource = clsDDocumento.CargarComboDocumento();
                comboBox1.DisplayMember = "nombreDocumento";
                comboBox1.ValueMember = "iDDocumento";
            }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmProducto buscar = new FrmProducto();
            buscar.Show();
        }
    }
    }
