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

namespace Sistema_de_parqueo.Forms
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
            lblNombre.Text=Session.customer_name+" "+Session.customer_lastname;
            lblDUI.Text = Session.customer_DUI;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panelEstacionamiento_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush pincel = new SolidBrush(Color.Blue);
            Pen lapiz = new Pen(pincel);

            g.DrawEllipse(lapiz, new Rectangle(400, 280, 80, 80));

            DibujarEstacionamientos EstacionamientoA = new DibujarEstacionamientos('A', 230, 150);
            DibujarEstacionamientos EstacionamientoB = new DibujarEstacionamientos('B', 560, 150);
            DibujarEstacionamientos EstacionamientoC = new DibujarEstacionamientos('C', 230, 350);

            EstacionamientoA.Dibujar(g, pincel, lapiz);
            EstacionamientoB.Dibujar(g, pincel, lapiz);
            EstacionamientoC.Dibujar(g, pincel, lapiz);
        }
    }
}
