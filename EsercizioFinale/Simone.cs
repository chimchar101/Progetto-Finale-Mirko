using System;

public interface IProdotto
{
    string Descrizione();
}

public class ProdottoIgiene : IProdotto
{
    public string Descrizione()
    {
        return "Sgrassatore Multiuso";
    }

    public double Prezzo()
    {
        return 3.75;
    }
}

public class ProdottoAlimentare : IProdotto
{
    public string Descrizione()
    {
        return "Casco di Banane";
    }

    public double Prezzo()
    {
        return 1.49;
    }
}

public class ProdottoElettronica : IProdotto
{
    public string Descrizione()
    {
        return "Powerbank Cellulare";
    }

    public double Prezzo()
    {
        return 39.99;
    }
}

public static class ProdottoFactory
{
    public static IProdotto CreaProdotto(string prodotto)
    {
        switch (prodotto)
        {
            case "1":
                return new ProdottoIgiene();
            case "2":
                return new ProdottoAlimentare();
            case "3":
                return new ProdottoElettronica();
            default:
                Console.WriteLine("ERRORE INPUT - Ritorno al menù.");
                return null;
        }
    }
}