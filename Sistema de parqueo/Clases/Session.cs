using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_parqueo.Clases
{
    internal class Session
    {
        public static int id_customer { get; set; }
        public static string customer_name { get; set; }
        public static string customer_lastname { get; set; }
        public static string customer_DUI { get; set; }
        public static string customer_password { get; set; }
        public  int IDcustomer {
            get { return id_customer; }
            set { id_customer = value; }
        }
        public string Customer_name { get { return customer_name; } set { customer_name = value; } }
        public string Customer_Lastname { get { return customer_lastname; } set { customer_lastname = value; } }
        public string Customer_DUI { get { return customer_DUI; } set { customer_DUI = value; } }



    }
}
