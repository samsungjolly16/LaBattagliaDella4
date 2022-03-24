using LaBattagliaDellaClasse4;
try
{
    Uomo u1 = new Uomo();
    Personaggio p = new Personaggio("Tommaso", u1);
    p.Esperienza = 2;
    Personaggio p1 = new Personaggio("stregone", new Stregone());
    p.Attacca(p1);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
