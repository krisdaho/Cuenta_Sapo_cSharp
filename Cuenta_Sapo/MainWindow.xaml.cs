using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
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

    public partial class MainWindow : Window
    {

        // con esto se declara la LISTA y el acceso a la ventana (archivo) CUENTA_PUNTOS, lo que permite que despues se instancie en el constructor del main que es public mainwindow() y de esta forma podran accederse a todas las propiedades desde cualquier contexto del main.
        private List<Jugadores> ListaJugadores;
        private Cuenta_Puntos AccesoCuentaPuntos;

        public MainWindow()
        {
            InitializeComponent();
            ListaJugadores = new List<Jugadores>();
            Cuenta_Puntos AccesoCuentaPuntos = new Cuenta_Puntos(ListaJugadores);
        }


        public string obtenerNombreJugador;
        public byte contador = 0;
        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            AccesoCuentaPuntos.Show();

            //this.Close();
                                 

        }

        //Este Boton representa al de "registrar Jugadores"
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
                         
            //se obtiene el nombre que se escribe en el TEXT BOX
            obtenerNombreJugador = txt_ObtenerNombre.Text;

            //Se agrega a la lista el dato del text box y se instancia la clase jugadores sin afectaciones, creando un objeto anonimo.
            //ListaJugadores.Add(new Jugadores(obtenerNombreJugador, 0));

            //miListBox.Items.Add(ListaJugadores[contador].NombreJugador);
            getListaJugadores();
            contador++;

            //*****PROBANDO AGREGAR NOMBRE DE CADA JUGADOR

            //ITEMSOURCE permite que tablamain tome todos los valores que se han agregado en LISTAJUGADORES
            //con COLUMS estamos organizando en que posicion debe aparecer 
            //ITEMS.REFRESH() nos permite actualizar el datagrid para que todo lo que se ha agregado vaya apareciendo mientra se digita.
            tablaMain.ItemsSource = ListaJugadores;

            tablaMain.Columns[0].DisplayIndex = 1;

            tablaMain.Items.Refresh();


            AccesoCuentaPuntos = new Cuenta_Puntos(ListaJugadores);

            txt_ObtenerNombre.Text = "";
            
        }

        

        public void getListaJugadores()
        {
            ListaJugadores.Add(new Jugadores(obtenerNombreJugador, 0));

            miListBox.Items.Add(ListaJugadores[contador].NombreJugador);

            
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

       

        private void tablaMain_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            
        }
    }

}