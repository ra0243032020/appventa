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
    public partial class FrmMenuVenta : Form
    {
        public FrmMenuVenta()
        {
            InitializeComponent();
        }

        private void frmVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        public static FrmVenta frmVenta = new FrmVenta();


        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta.Show();
        }

        private void FrmMenuVenta_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
