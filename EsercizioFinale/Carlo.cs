
//OBSERVER PATTERN - CARLO
public interface IObserver
{
    void Notifica(string messaggio);
}
public class Ordine : IObserver
{
    public string Nome { get; set; }
    public string Descrizione { get; set; }

    public Ordine(string nome, string descrizione)
    {
        Nome = nome;
        Descrizione = descrizione;
    }

    public void Notifica(string messaggio)
    {
        System.Console.WriteLine($"Ordine {Nome} notificato: {messaggio}");
    }
}


//DECORATOR PATTERN - CARLO
public interface INImballaggio
{
    string Descrizione();
}
public class ProdottoBase : INImballaggio
{
    private string _nome;
    public ProdottoBase(string nome)
    {
        _nome = nome;
    }
    public string Descrizione()
    {
        return _nome;
    }
}
public abstract class DecoratorImballaggio : INImballaggio
{
    protected INImballaggio _prodotto;

    public DecoratorImballaggio(INImballaggio prodotto)
    {
        _prodotto = prodotto;
    }

    public virtual string Descrizione()
    {
        return _prodotto.Descrizione();
    }
}

public class Inscatolato : DecoratorImballaggio
{
    public Inscatolato(INImballaggio prodotto) : base(prodotto) { }

    public override string Descrizione()
    {
        return _prodotto.Descrizione() + " (Inscatolato)";
    }
}

public class Regalo : DecoratorImballaggio
{
    public Regalo(INImballaggio prodotto) : base(prodotto) { }

    public override string Descrizione()
    {
        return _prodotto.Descrizione() + " (Regalo)";
    }
}
