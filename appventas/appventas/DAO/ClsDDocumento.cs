using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsDDocumento
    {

        public List<tb_documento> CargarComboDocumento()
        {



            List<tb_documento> tb_documento = new List<tb_documento>();
            using (sistema_ventasEntities bd = new sistema_ventasEntities())
            {
                tb_documento = tb_documento.ToList();



            }

            return tb_documento;
        }
    }
}
