using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracticaLineas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Sol();
            Techo();
            Casa();
            Puerta();
            Ventana();
            Tallo();
            Arbol();
            Cesped();
        }

        public void Sol()
        {
            for (int i=0; i<360; i++)
            {
                plnSol.Points.Add(new Point(Math.Cos(i) * 50 + 60, Math.Sin(i) * 50 + 60));
            }
        }

        public void Techo()
        {
            plnTecho.Points.Add(new Point(250, 100));
            plnTecho.Points.Add(new Point(350, 200));
            plnTecho.Points.Add(new Point(150, 200));
            plnTecho.Points.Add(new Point(250, 100));
        }

        public void Casa()
        {
            plnCasa.Points.Add(new Point(180, 200));
            plnCasa.Points.Add(new Point(180, 350));
    
            plnCasa.Points.Add(new Point(320, 350));
            plnCasa.Points.Add(new Point(320, 200));
        }

        public void Puerta()
        {
            plnPuerta.Points.Add(new Point(230, 350));
            plnPuerta.Points.Add(new Point(230, 300));

            plnPuerta.Points.Add(new Point(270, 300));
            plnPuerta.Points.Add(new Point(270, 350));
        }

        public void Ventana()
        {
            plnVentana.Points.Add(new Point(300, 220));
            plnVentana.Points.Add(new Point(250, 220));
            plnVentana.Points.Add(new Point(250, 270));
            plnVentana.Points.Add(new Point(300, 270));
            plnVentana.Points.Add(new Point(300, 220));

            plnVentana.Points.Add(new Point(275, 220));
            plnVentana.Points.Add(new Point(275, 270));

            plnVentana.Points.Add(new Point(250, 270));
            plnVentana.Points.Add(new Point(250, 245));

            plnVentana.Points.Add(new Point(250, 245));
            plnVentana.Points.Add(new Point(300, 245));
        }

        public void Tallo()
        {
            plnTallo.Points.Add(new Point(450, 220));
            plnTallo.Points.Add(new Point(450, 350));
            plnTallo.Points.Add(new Point(500, 350));
            plnTallo.Points.Add(new Point(500, 220));
        }

        public void Arbol()
        {
            plnArbol.Points.Add(new Point(450, 220));
            plnArbol.Points.Add(new Point(400, 170));
            plnArbol.Points.Add(new Point(475, 100));
            plnArbol.Points.Add(new Point(550, 170));
            plnArbol.Points.Add(new Point(500, 220));
        }

        public void Cesped()
        {
            plnCesped.Points.Add(new Point(30, 350));
            plnCesped.Points.Add(new Point(40, 360));
            plnCesped.Points.Add(new Point(50, 350));

            plnCesped.Points.Add(new Point(60, 350));
            plnCesped.Points.Add(new Point(70, 360));
            plnCesped.Points.Add(new Point(80, 350));

            plnCesped.Points.Add(new Point(90, 350));
            plnCesped.Points.Add(new Point(100, 360));
            plnCesped.Points.Add(new Point(110, 350));
        }
    }
}
