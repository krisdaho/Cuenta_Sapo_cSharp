using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Cuenta_Sapo;


namespace Cuenta_Sapo
{
    /// <summary>
    /// Lógica de interacción para Cuenta_Puntos.xaml
    /// </summary>
    public partial class Cuenta_Puntos : Window
    {
        int contador = 0;

        //Con la siguiente declaracion se inicializa la lista "jugadores" la cual se hace fuera del constructor de la clase MAINWINDOW con el proposito de que sea accesible desde cualquier contexto que este dentro de la clase, como por ejemplo dentro del constructor del MAINWINDOW para capturar los datos que se obtuvieron en la ventana inicial del programa.
        private List<Jugadores> ListaJugadores;
        public Cuenta_Puntos(List<Jugadores> obtenerJugadoresDeMain)
        {


            InitializeComponent();

            ListaJugadores = new List<Jugadores>();

            ListaJugadores.AddRange(obtenerJugadoresDeMain);


            tablaJugadores.ItemsSource = ListaJugadores;
                      

        }


        //Con este evento le damos funcionalidad al boton agregar para que este nos haga el trabajo de captar cada puntuacion de los jugadores, permitiedo agregarlos a la propiedad de la clase jugadores puntuacion que le pertenece a cda uno de los jugadores que estan en la lista.
        private void Agregar_Puntos_Click(object sender, RoutedEventArgs e)
        {
            int CaptacionPuntos = Convert.ToInt32(Puntos_txt.Text);

            int cantidadElementoList = ListaJugadores.Count;

            if (cantidadElementoList >= contador + 1) 
            {

                ListaJugadores[contador].Puntuacion = CaptacionPuntos;
                               
                contador++;
                          

            }

            if (contador == cantidadElementoList)
            {
                contador = 0;
            }

            tablaJugadores.Items.Refresh();
                        
            Puntos_txt.Text = "";
        }


    }
}
