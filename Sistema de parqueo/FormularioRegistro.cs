using Sistema_de_parqueo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sistema_de_parqueo
{
    public partial class FormularioRegistro : Form
    {
        String nombre, apellido, Dui, contraseña;
        AppDbContext db = new AppDbContext();

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormularioRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormLogin();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Encriptar encriptar = new Encriptar();
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            Dui = txtDui.Text;
            contraseña = txtContraseña.Text;
            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido) && !string.IsNullOrEmpty(contraseña))
            {
                if (encriptar.verificarDui(Dui))
                {
                    Login login = new Login();
                    //Si dui Ya existe
                    if (login.ExisteDUI(Dui))
                    {
                        MessageBox.Show("Este Dui ya existe con otro usuario");

                    }
                    else
                    {
                        // insert
                        //using (estacionamientoEntities db = new estacionamientoEntities())
                        //{
                        //    var customers = db.Set<customer>();
                        //    customers.Add(new customer
                        //    {
                        //        customer_name = nombre,
                        //        customer_lastname = apellido,
                        //        customer_DUI = Dui,
                        //        customer_password = contraseña
                        //    });

                        //    db.SaveChanges();
                        //}
                        //Usando el AppDbContext
                        try
                        {
                            customer client = new customer
                            {
                                customer_name = nombre,
                                customer_lastname = apellido,
                                customer_DUI = Dui,
                                customer_password = contraseña
                            };
                            db.customers.Add(client);
                            db.SaveChanges();

                            MessageBox.Show("Dato creado");
                            this.Hide();
                            var form2 = new FormLogin();
                            form2.Closed += (s, args) => this.Close();
                            form2.Show();
                        }catch(Exception ex)
                        {
                            MessageBox.Show("Ha ocurrido algo malo. Error: " + ex.Message);
                        }
                    }


                }
                else
                {
                    MessageBox.Show("Ingrese su dui de forma correcta\n" +
                        "Con este formato: 12345678-9 ");
                }

            }
            else
            {
                MessageBox.Show("Ingrese todos los campos requeridos");
            }




        }
    }
}
