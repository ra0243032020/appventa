using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDCliente
    {

        public List<tb_cliente> CargarComboCliente() {



            List<tb_cliente> tb_cliente = new List<tb_cliente>();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_cliente = tb_cliente.ToList();



            }
             
            return tb_cliente;
        }
        


        
        
        
        
        
        



    }
}
