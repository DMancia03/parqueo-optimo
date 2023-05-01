namespace Proyecto_Catedra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_paint(object sender, PaintEventArgs e)
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