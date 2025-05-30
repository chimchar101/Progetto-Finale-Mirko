using System;

public interface IConsegnaStrategia
{
    string Consegna(string descrizione);
}

public class ConcreteStrategyConsegnaDomicilio : IConsegnaStrategia
{
    public string Consegna(string descrizione)
    {
        return descrizione + " hai scelto la consegna a domicilio";
    }
}

public class ConcreteStrategyRitiroInMagazzino : IConsegnaStrategia
{
    public string Consegna(string descrizione)
    {
        return descrizione + " hai scelto il ritiro in magazzino";
    }
}

public class ConcreteStrategyConsegnaPuntoRitiro : IConsegnaStrategia
{
    public string Consegna(string descrizione)
    {
        return descrizione + " hai scelto la consegna presso un punto di ritiro";
    }
}

public class ConsegnaContext
{
    private IConsegnaStrategia _strategia;

    public ConsegnaContext(IConsegnaStrategia strategia)
    {
        _strategia = strategia;
    }

    public void ImpostaStrategia(IConsegnaStrategia strategia)
    {
        _strategia = strategia;
    }

    public string EseguiConsegna(string descrizione)
    {
        return _strategia.Consegna(descrizione);
    }
}



