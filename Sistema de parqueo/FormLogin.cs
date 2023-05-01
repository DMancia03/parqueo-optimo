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

namespace Sistema_de_parqueo
{
    public partial class FormLogin : Form
    {
        Login login =new Login();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormularioRegistro();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            String dui = textBox1.Text;
            String contraseña = txtContraseña.Text;
            if (login.ExisteUsuario(dui, contraseña))
            {
                login.obtenerDatosUsuario(dui, contraseña);

                this.Hide();
                var form2 = new Dashboard();
                form2.Closed += (s, args) => this.Close();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Usuario Inexistente, verifique sus credenciales o Registrese");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FormularioRegistro();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
