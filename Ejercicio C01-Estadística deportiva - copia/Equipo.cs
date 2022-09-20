using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01_Estadística_deportiva
{
    public class Equipo
    {
        private short _cantidadJugadores;
        private List<Jugador> _jugadores;
        private string _nombre;

        private Equipo()
        {
            _cantidadJugadores = 0;
            _jugadores = new List<Jugador>();
            _nombre = "";
        }

        public Equipo(short cantidadJugadores, string nombre) : this()
        {
            _cantidadJugadores = cantidadJugadores;
            _nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e._jugadores.Count < e._cantidadJugadores)
            {
                foreach(Jugador jugador in e._jugadores)
                {
                    if(jugador == j)
                    {
                        return false;
                    }
                }
                e._jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
