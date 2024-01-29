// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



static void Main()
{
    Atleta primo = new Atleta();
    primo.nome = "SUPERSIUM";
    primo.stipendio = 100000;
    primo.sport = "calcio";
    primo.ranking = 1;
    Console.WriteLine(primo.Statsatleta());

    Dipendente secondo = new Dipendente();
    secondo.Lavoro = "Calcolatore";
    Console.WriteLine(secondo.superDipendente());

    Animale terzo = new Animale();
    terzo.specie = "Cane";
    terzo.anni = 5;
    Console.WriteLine(terzo.statAnimale());

    Veicolo quarto = new Veicolo();
    quarto.marca = "Audi";
    quarto.cavalli = 199999;
    Console.WriteLine(quarto.statsVeicolo());



}
Main();

public class Atleta
{
    public string nome = "Nome non impostato";
    public int stipendio;
    public string sport="Sport non impostato";
    public int ranking;
    public string Statsatleta()
    {
        return $"L'atleta di nome: {nome} pratica lo sport : {sport} è posizionato al rank:{ranking} e percepisce {stipendio} euro di stipendio";
    }

}
public class Dipendente 
{
    public string lavoro = "Lavoro non impostato";
    public string Lavoro
    {
        get { return ""; }
        set { lavoro= $"Il suo lavoro è{value}"; }
    }
    public int salario ;
    public string mansione = "Mansione non impostata";
    public string superDipendente()
    {
        return $"{lavoro}+{salario}+{mansione}";
    }




}

public class Animale
{
    public string specie = "Specie non impostata";
    public int anni;
    public string statAnimale()
    {
        return $"{specie}+{anni}";
    }

}
public class Veicolo
{
    public string marca = "Marca non impostata";
    public int cavalli;
    public string statsVeicolo()
    {
        return $"{marca}+{cavalli}";
    }

}

