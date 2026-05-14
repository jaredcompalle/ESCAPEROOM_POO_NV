using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCAPEROOM_POO_NV
{
    abstract class Acertijo : IResoluble, IPuntuacion
    {
        public string Pregunta { get; set; }
        public int Intentos { get; set; }
        public abstract bool ValidarRespuesta(string respuesta);
        public abstract void EnviarPista();
        bool IResoluble.Resolver(string respuesta)
        {
            if (ValidarRespuesta(respuesta))
            {
                return true;
            }
            else
            {
                Intentos++;
                return false;
            }
        }
        int IPuntuacion.GanarPuntos(int tiempo, string respuesta)
        {
            int Puntos = 0;
            if (tiempo >= 40) Puntos = 100;
            if (tiempo < 40) Puntos = (100) - (int)((40 - tiempo) * 2.5);
            return Puntos;
        }

    }
}
