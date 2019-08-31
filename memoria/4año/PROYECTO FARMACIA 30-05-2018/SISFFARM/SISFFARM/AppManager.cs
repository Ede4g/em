using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISFFARM
{
    class AppManager:ApplicationContext
    {
        public AppManager()
        {
            Splash();
            if(Login())
            {
                //SI EL USUARIO Y LA CONTRASEÑA SON CORRECTAS
                MenuPrincipal frm = new MenuPrincipal();
                frm.ShowDialog();
            }
            else
            {
                //SI EL USUARIO O LA CONTRASEÑA NO SON CORRECTOS
            }
        }
        private void Splash()
        {
            //CREAMOS UN OBJETO CON EL OPERADOR NEW
            Splash frm = new SISFFARM.Splash();
            //MOSTRAMOS EL FORMULARIO
            frm.ShowDialog();
        }
        private Boolean Login()
        {
            //CREAMOS UN OBJETO LOGIN
            Login frm = new SISFFARM.Login();
            //MOSTRAMOS EL OBJETO FORMULARIO
            frm.ShowDialog();
            //DEVOLVEMOS EL VALOR DE LA PROPIEDAD
            return frm.Autorizado; 
        }
    }
}
