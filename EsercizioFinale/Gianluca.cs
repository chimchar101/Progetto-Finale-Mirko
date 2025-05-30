using System;
using System.Collections.Generic;

//Classe Magazzino Singleton
public sealed class Magazzino
{
    private static Magazzino _istanza;

    private List<IProdotto> _prodotti = new List<IProdotto>();

    private Magazzino() { }

    public static Magazzino Istanza
    {
        get
        {
                if (_istanza == null)
                {
                    _istanza = new Magazzino();
                }
                return _istanza;
        }
    }

    public void AggiungiProdotto(IProdotto prodotto)
    {
        _prodotti.Add(prodotto);
    }

    public void RimuoviProdotto(IProdotto prodotto)
    {
        _prodotti.Remove(prodotto);
    }
    public void CercaProdotto(string prodotto)
    {
        foreach (var p in _prodotti)
        {
            if (p.Descrizione().ToLower() == prodotto.ToLower())
            {
                Console.WriteLine("Prodotto trovato: " + p.Descrizione() + " - Prezzo: " + p.Prezzo());
            }
        }
    }
    public void VisualizzaProdotti()
    {
        Console.WriteLine("Prodotti nel magazzino:");
        for (int i = 0; i < _prodotti.Count; i++)
        {
            Console.WriteLine($"[{i + 1}] {_prodotti[i].Descrizione()} - Prezzo: {_prodotti[i].Prezzo()}");
        }
        Console.WriteLine("---------------------------");
    }
}