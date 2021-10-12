using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Citas
{
    public class SeguridadBL
    {
        public bool Autorizar(string  Usuario,  string  Contraseña)
        {
            if(Usuario == "admin" && Contraseña == "123")
            {
                return true;
            }
            else
            {
                 if (Usuario == "user" && Contraseña == "456")
                {
                    return true;
                }
            }
            return false;   
       }
    }
}
