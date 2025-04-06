using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanzado_Semana_1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego de aventura de texto.");
            Console.Write("Ingresa tu nombre: ");
            string name = Console.ReadLine();

            Player player = new Player(name, 100);
            Scenery scenery = new Scenery();

            int decisionsmade = 0;

            while (decisionsmade  < 5 && player.Life > 0)
            {
                Console.WriteLine("\nElige una acción:");
                string[] optiones = scenery.GetOptions();

                for (int i = 0; i < optiones.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {optiones[i]}");
                }

                Console.Write("Tu elección: ");
                string entrada = Console.ReadLine();
                int eleccion;
                bool esNumero = int.TryParse(entrada, out eleccion);

                if (!esNumero || eleccion < 1 || eleccion > optiones.Length)
                {
                    Console.WriteLine("Opción inválida.");
                    continue;
                }

                string SelectedOption = optiones[eleccion - 1];
                player.MakeDecision(SelectedOption);

                string result = scenery.ExecuteDecision(SelectedOption);
                Console.WriteLine(result);

                switch (SelectedOption)
                {
                    case "bosque":
                        player.Life -= 10;
                        break;
                    case "cueva":
                        player.AddInventory("Espada mágica");
                        break;
                    case "rio":
                        player.Life += 10;
                        break;
                    case "aldea":
                        player.AddInventory("Mapa del tesoro");
                        break;
                    case "castillo":
                        player.Life -= 50;
                        break;
                    default:
                        break;
                }

                decisionsmade++;               
                player.ShowStatus();

                if (player.Life <= 0)
                {
                    Console.WriteLine("Has muerto. Fin del juego.");
                    return;
                }
            }

            Console.WriteLine("\n¡Aventura terminada!");
            if (player.Life > 0)
                Console.WriteLine("¡Felicidades! Sobreviviste la aventura.");
        }
    
    }
}
