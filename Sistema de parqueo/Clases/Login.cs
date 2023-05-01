using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_parqueo.Clases
{
    internal class Login
    {
        public Boolean ExisteUsuario(String dui, String contraseña)
        {
            Boolean existe = false;
            //using (estacionamientoEntities db = new estacionamientoEntities())
            //{
            //    var lst = from d in db.customer where d.customer_DUI == dui && d.customer_password == contraseña select d;
            //    if (lst.Count() > 0)
            //    {
            //        existe = true;
            //    }
            //    else
            //    {
            //        existe = false;
            //    }
            //}
            return existe;

        }
        public Boolean ExisteDUI(String dui)
        {
            Boolean existe = false;
            //using (estacionamientoEntities db = new estacionamientoEntities())
            //{
            //    var lst = from d in db.customer where d.customer_DUI == dui select d;
            //    if (lst.Count() > 0)
            //    {
            //        existe = true;
            //    }
            //    else
            //    {
            //        existe = false;
            //    }
            //}
            return existe;

        }
        public void obtenerDatosUsuario(String dui, String contraseña)
        {
            Session sess = new Session();

            //using (estacionamientoEntities db = new estacionamientoEntities())
            //{
            //    var lst = from d in db.customer where d.customer_DUI == dui && d.customer_password == contraseña select d;
            //    var datos = lst.FirstOrDefault<customer>();
            //    sess.IDcustomer = datos.id_customer;
            //    sess.Customer_Lastname = datos.customer_lastname;
            //    sess.Customer_name = datos.customer_name;
            //    sess.Customer_DUI = datos.customer_DUI;


            //}
        }
        public void CerrarSession()
        {
            Session sess = new Session();
        }

    }
}
