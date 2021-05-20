using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDProducto
    {
        public List<tb_producto> CargarProductosFiltro(String filtro)
        {



            List<tb_producto> tb_Productos = new List<tb_producto>();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_Productos = (from listadoproductos in bd.tb_producto
                                where listadoproductos.nombreProducto.Contains(filtro)
                                select listadoproductos).ToList();

            }

            return tb_Productos;
        }

    }
}
