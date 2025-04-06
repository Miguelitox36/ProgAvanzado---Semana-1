using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanzado_Semana_1
{
    public class Player : Character, IInterpretable
    {
        public List<string> Inventary;

        public Player(string name, int life) : base(name, life)
        {
            Inventary = new List<string>();
        }

        public override void ShowStatus()
        {
            Console.WriteLine($"Jugador: {Name} - Vida: {Life}");
            Console.WriteLine("Inventario:");
            foreach (var item in Inventary)
            {
                Console.WriteLine($" - {item}");
            }
        }

        public void MakeDecision(string option)
        {
            Console.WriteLine($"Has elegido: {option}");
        }

        public void AddInventory(string item)
        {
            Inventary.Add(item);
        }
    }
}
