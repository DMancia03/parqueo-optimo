using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Sistema_de_parqueo
{
    class Lugares
    {
        private int X;
        private int Y;
        private string nombre;
        private bool estado;

        public Lugares(int x, int y, string Nombre)
        {
            X = x;
            Y = y;
            nombre = Nombre;
            estado = false;
        }

        public int ValX { get { return X; } set { X = value; } }
        public int ValY { get { return Y; } set { Y = value; } }    
        public string Nombre { get {  return nombre; } set {  nombre = value; } }
        public bool Estado { get { return estado; } set {  estado = value; } }

        public void DibujarPunto(Graphics g)
        {

            if(Estado == true)
            {
                Brush pincel = new SolidBrush(Color.DarkGreen);
                Pen lapiz = new Pen(pincel);
                g.DrawEllipse(lapiz, new Rectangle(ValX - 5, ValY, 10, 10));
                g.FillEllipse(pincel, new Rectangle(ValX - 5, ValY, 10, 10));
            }
            else
            {
                Brush pincel = new SolidBrush(Color.Red);
                Pen lapiz = new Pen(pincel);
                g.DrawEllipse(lapiz, new Rectangle(ValX - 5, ValY, 10, 10));
                g.FillEllipse(pincel, new Rectangle(ValX - 5, ValY, 10, 10));
            }
        }

    }
}
