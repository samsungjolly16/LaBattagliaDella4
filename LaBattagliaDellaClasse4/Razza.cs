using System;
using System.Collections.Generic;
using System.Text;

namespace LaBattagliaDellaClasse4
{
    public abstract class Razza
    {
        public bool IsBene { get; internal set; }
        public int Attacco { get; private set; }
        public int Difesa { get; private set; }
        public Razza()
        {
            Random r = new Random();
            Attacco = r.Next(10);
            Difesa = r.Next(10);
        }
    }
}
