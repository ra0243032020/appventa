using appventas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appventas.DAO
{
    class ClsAcceso
    {
        public int acceso(string usuario, string password)
        {
            int variabledeacceso=0;
            using (sistema_ventasEntities bd = new sistema_ventasEntities() ) {

                var consulta = from user in bd.tb_usuario
                               where user.email == usuario && user.contrasena == password
                               select user; 
                
                if (consulta.Count() > 0)
                {
                    variabledeacceso = 1;

                }
            }
        
              return 0;
        }

    }
}
