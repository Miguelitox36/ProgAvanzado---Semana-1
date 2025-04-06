using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanzado_Semana_1
{
    public class Scenery
    {
        private Dictionary<string, string> decisions;

        public Scenery()
        {
            decisions = new Dictionary<string, string>
            {
                
                    { "bosque", "Te adentras en el bosque y escuchas ruidos extraños..." },
                    { "cueva", "La cueva es oscura, pero encuentras un cofre brillante." },
                    { "rio", "En el río, ves algo flotando... ¡es una poción de vida!" },
                    { "aldea", "La aldea está vacía, pero encuentras un mapa." },
                    { "castillo", "Entras al castillo y te enfrentas al jefe final." }
            };
        }
        public string ExecuteDecision(string decision)
        {
            if (decisions.ContainsKey(decision))
                return decisions[decision];
            else
                return "Esa opción no existe...";
        }

        public string[] ObtenerOpciones()
        {
            string[] options = new string[decisions.Count];
            decisions.Keys.CopyTo(options, 0);
            return options;
        }

       
    }
}

