using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESCAPEROOM_POO_NV
{
    internal class GestorAcertijo : Acertijo
    {
        private string _respuestaCorrecta;
        private string _pista;
        public GestorAcertijo(string pregunta, string respuesta, string pista)
        {
            Pregunta = pregunta;
            _respuestaCorrecta = respuesta.ToLower();
            Intentos = 0;
            _pista = pista;
        }
        
        public override bool ValidarRespuesta(string respuesta)
        {
            return respuesta.Trim().ToLower() == _respuestaCorrecta;
        }
        public override void EnviarPista()
        {
            MessageBox.Show($"{_pista}");
        }
    }
}
