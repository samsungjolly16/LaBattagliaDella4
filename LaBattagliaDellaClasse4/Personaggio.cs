using System;

namespace LaBattagliaDellaClasse4
{
    public class Personaggio
    {
        public UInt16 Vita { get; private set; }
        public UInt16 Esperienza { get;  set; }
        public string Nome { get; private set; }
        public Razza _Razza { get; private set; }
        public Personaggio(string nome,Razza razza)
        {
            Nome = nome;
            _Razza = razza;
            Vita = 100;
            Esperienza = 1;
        }
        public void Attacca(Personaggio p)
        {
            if (_Razza == p._Razza)
            {
                throw new Exception("Attenzione nuon puoi attaccare un personaggio dello stesso schieramento ");
            }else
            {
                int attacco =  Attacco(this);
                int difesa = Difesa(p);
                if (attacco > difesa)
                {
                    p.Vita--;
                    if (p.Vita <= 0)
                        throw new Exception(p.Nome + " è morto.");
                }
                else if (attacco <= difesa)
                {
                    int attacco1= Attacco(p);
                    int difesa1=Difesa(this);
                    if (attacco1 > difesa1)
                    {
                        Vita--;
                        if(Vita<=0)
                            throw new Exception(p.Nome + " è morto.");
                    }
                }
                throw new Exception("battaglia terminata\n"+Nome+":"+Vita+" vita rimasta \n"+ p.Nome+ ":" + p.Vita + " vita rimasta");
            }

        }

        private static int Difesa(Personaggio p)
        {
            return p.Esperienza * p._Razza.Difesa;
        }

        private static int Attacco(Personaggio p)
        {
            return p.Esperienza * p._Razza.Attacco;
        }
        
    }
}
