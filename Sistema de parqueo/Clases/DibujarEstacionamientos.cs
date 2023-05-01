using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sistema_de_parqueo
{
    class DibujarEstacionamientos
    {
        private char nombre;
        private int x;
        private int y;
        

        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }   
        public char Nombre { get {  return nombre; } set {  nombre = value; } }

        public DibujarEstacionamientos(char nombre, int x, int y)
        {
            X = x;
            Y = y;
            Nombre = nombre;
        }

        public void Dibujar(Graphics g, Brush pincel, Pen lapiz)
        {
            //Contorno del estacionamiento
            Point[] puntos = new Point[5];
            puntos[0] = new Point(X, Y);
            puntos[1] = new Point(X, Y - 130);
            puntos[2] = new Point(X - 220, Y - 130);
            puntos[3] = new Point(X - 220, Y + 50);
            puntos[4] = new Point(X - 30, Y + 50);
            g.DrawLines(lapiz, puntos);

            Rectangle[] rectangulos = new Rectangle[14];
            // Estacionamientos de abajo
            rectangulos[0] = new Rectangle(X - 40, Y - 30, 1, 40);
            rectangulos[1] = new Rectangle(X - 70, Y - 30, 1, 40);
            rectangulos[2] = new Rectangle(X - 100, Y - 30, 1, 40);
            rectangulos[3] = new Rectangle(X - 130, Y - 30, 1, 40);
            rectangulos[4] = new Rectangle(X - 160, Y - 30, 1, 40);
            rectangulos[5] = new Rectangle(X - 190, Y - 30, 1, 40);
            rectangulos[6] = new Rectangle(X - 190, (Y - 30) + 20, 150, 1);

            //Circulos en posición estacionamiento abajo Linea de abajo
            Lugares Espacio1 = new Lugares(X - ((40 + 70) / 2), Y - 4, Nombre + "1");
            Lugares Espacio2 = new Lugares(X - ((70 + 100) / 2), Y - 4, Nombre + "2");
            Lugares Espacio3 = new Lugares(X - ((100 + 130) / 2), Y - 4, Nombre + "3");
            Lugares Espacio4 = new Lugares(X - ((130 + 160) / 2), Y - 4, Nombre + "4");
            Lugares Espacio5 = new Lugares(X - ((160 + 190) / 2), Y - 4, Nombre + "5");
            Espacio1.DibujarPunto(g);
            Espacio2.DibujarPunto(g);
            Espacio3.DibujarPunto(g);
            Espacio4.DibujarPunto(g);
            Espacio5.DibujarPunto(g);
            //Circulos en posición estacionamiento abajo Linea de arriba
            Lugares Espacio6 = new Lugares(X - ((40 + 70) / 2), Y - 25, Nombre + "6");
            Lugares Espacio7 = new Lugares(X - ((70 + 100) / 2), Y - 25, Nombre + "7");
            Lugares Espacio8 = new Lugares(X - ((100 + 130) / 2), Y - 25, Nombre + "8");
            Lugares Espacio9 = new Lugares(X - ((130 + 160) / 2), Y - 25, Nombre + "9");
            Lugares Espacio10 = new Lugares(X - ((160 + 190) / 2), Y - 25, Nombre + "10");
            Espacio6.DibujarPunto(g);
            Espacio7.DibujarPunto(g);
            Espacio8.DibujarPunto(g);
            Espacio9.DibujarPunto(g);
            Espacio10.DibujarPunto(g);

            //Estacionamientos de arriba

            rectangulos[7] = new Rectangle(X - 40, Y - 100, 1, 40);
            rectangulos[8] = new Rectangle(X - 70, Y - 100, 1 , 40);
            rectangulos[9] = new Rectangle(X - 100, Y - 100, 1, 40);
            rectangulos[10] = new Rectangle(X - 130, Y - 100, 1, 40);
            rectangulos[11] = new Rectangle(X - 160, Y - 100, 1, 40);
            rectangulos[12] = new Rectangle(X - 190, Y - 100, 1, 40);
            rectangulos[13] = new Rectangle(X - 190, (Y - 100) + 20, 150, 1);
            g.DrawRectangles(lapiz, rectangulos);

            //Circulos en posición Estacionamiento arriba Linea de abajo
            Lugares Espacio11 = new Lugares(X - ((40 + 70) / 2), Y - 75, Nombre + "11");
            Lugares Espacio12 = new Lugares(X - ((70 + 100) / 2), Y - 75, Nombre + "12");
            Lugares Espacio13 = new Lugares(X - ((100 + 130) / 2), Y - 75, Nombre + "12");
            Lugares Espacio14 = new Lugares(X - ((130 + 160) / 2), Y - 75, Nombre + "14");
            Lugares Espacio15 = new Lugares(X - ((160 + 190) / 2), Y - 75, Nombre + "15");
            Espacio11.DibujarPunto(g);
            Espacio12.DibujarPunto(g);
            Espacio13.DibujarPunto(g);
            Espacio14.DibujarPunto(g);
            Espacio15.DibujarPunto(g);
            Lugares Espacio16 = new Lugares(X - ((40 + 70) / 2), Y - 95, Nombre + "16");
            Lugares Espacio17 = new Lugares(X - ((70 + 100) / 2), Y - 95, Nombre + "17");
            Lugares Espacio18 = new Lugares(X - ((100 + 130) / 2), Y - 95, Nombre + "18");
            Lugares Espacio19 = new Lugares(X - ((130 + 160) / 2), Y - 95, Nombre + "19");
            Lugares Espacio20 = new Lugares(X - ((160 + 190) / 2), Y - 95, Nombre + "20");
            Espacio16.DibujarPunto(g);
            Espacio17.DibujarPunto(g);
            Espacio18.DibujarPunto(g);
            Espacio19.DibujarPunto(g);
            Espacio20.DibujarPunto(g);

        }

    }
}
