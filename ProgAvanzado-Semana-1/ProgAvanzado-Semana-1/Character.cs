using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgAvanzado_Semana_1
{
    public abstract class Character
    {
        public string Name;
        public int Life;

        public Character(string name, int life)
        {
            this.Name = name;
            this.Life = life;
        }

        public abstract void ShowStatus();
    }
}
