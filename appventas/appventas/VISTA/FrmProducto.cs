using appventas.DAO;
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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }
        void cargardatos(){

            ClsDProducto clsDProducto = new ClsDProducto();
            dataGridView1.Rows.Clear();

            foreach (var listarDatos in clsDProducto.CargarProductosFiltro(textBox1.Text)) {

                dataGridView1.Rows.Add(listarDatos.idProducto, listarDatos.nombreProducto, listarDatos.precioProducto);
            }
            cargardatos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cargardatos();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string Nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string Precio = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            //FrmVenta frmVenta = new FrmVenta();
            //frmVenta.txtId.Text = id;
            //frmVenta.txtNombre.Text = Nombre;
            //frmVenta.txtprecio.Text = Precio;
            //frmVenta.Show();


            FrmMenuVenta.frmVenta.txtId.Text = id;
            FrmMenuVenta.frmVenta.txtNombre.Text = Nombre;
            FrmMenuVenta.frmVenta.txtprecio.Text = Precio;
            this.Close();
        }
    }
}
