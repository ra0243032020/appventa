using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsUsuario
    {

        public List<bd_usuario> CargarUsuario()
        {
            List<bd_usuario> Lista;

            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                Lista = bd.tb_usuario.ToList();
    
            }
            return null;




        }
    }
}
