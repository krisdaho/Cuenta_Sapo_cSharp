using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace Cuenta_Sapo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string obtenerNombreJugador;
        public byte contador = 0;
        List<Jugadores> ListaJugadores = new List<Jugadores>();




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Cuenta_Puntos ventana1 = new Cuenta_Puntos();

            ventana1.Show();

            this.Close();

        }

        //Este Boton representa al de "registrar Jugadores"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            //se obtiene el nombre que se escribe en el text box
            obtenerNombreJugador = txt_ObtenerNombre.Text;

            //Se agrega a la lista el dato del text box y se instancia la clase jugadores sin afectaciones, creando un objeto anonimo.
            ListaJugadores.Add(new Jugadores(obtenerNombreJugador, 0));

            miListBox.Items.Add(ListaJugadores[contador].NombreJugador);
                       
            contador++;


        }


        class Jugadores
        {
            private string nombreJugador;
            private int puntuacion;

            public Jugadores(string NombreJugador, int Puntuacion)
            {
                this.nombreJugador = NombreJugador;
                this.puntuacion = Puntuacion;


            }

            public int Puntuacion { get => puntuacion; set => puntuacion = value; }
            public string NombreJugador { get => nombreJugador; set => nombreJugador = value; }
        }


        

        



        

        private void Si_Checked(object sender, RoutedEventArgs e)
        {
            if (Si.IsChecked == true)
            {
                GridTurnos.Visibility = Visibility.Visible;

            }
           
               
           
        }

        private void No_Checked(object sender, RoutedEventArgs e)
        {
            if (No.IsChecked == true)
            {
                GridTurnos.Visibility = Visibility.Hidden;
            }
        }
    }

}