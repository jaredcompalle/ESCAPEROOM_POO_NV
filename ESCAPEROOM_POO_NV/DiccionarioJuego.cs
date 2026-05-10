using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESCAPEROOM_POO_NV
{
    internal class DiccionarioJuego
    {
        public static string Actual = "es";

        // Un diccionario que guarda las frases
        // Clave: "txtSalir" -> Valor: "¿Deseas salir?"
        private static Dictionary<string, string> DiccionarioEs = new Dictionary<string, string>();
        private static Dictionary<string, string> DiccionarioEn = new Dictionary<string, string>();

        public static void Inicializar()
        {
            // Español

            // MENU PRINCIPAL
            DiccionarioEs.Add("menu_jugar", "JUGAR");
            DiccionarioEs.Add("menu_salir", "SALIR");
            DiccionarioEs.Add("menu_configuracion", "CONFIGURACION");

            DiccionarioEs.Add("dlg_inicio_1", "¡Vaya, finalmente despiertas!");

            // Inglés
            DiccionarioEn.Add("menu_jugar", "PLAY");
            DiccionarioEn.Add("menu_salir", "EXIT");
            DiccionarioEn.Add("dlg_inicio_1", "Oh, you're finally awake!");
        }

        public static string Obtener(string clave)
        {
            if (Actual == "es") return DiccionarioEs[clave];
            return DiccionarioEn[clave];
        }
    }
}

