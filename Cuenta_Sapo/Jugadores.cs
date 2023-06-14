using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Sapo
{
    public class Jugadores
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
}
