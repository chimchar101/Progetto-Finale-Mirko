using System;
using System.Collections.Generic;

//Classe Magazzino Singleton
public class Magazzino
{
    private static Magazzino _istanza;

    private List<Prodotto> _prodotti = new List<Prodotto>();

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

    public void AggiungiProdotto(Prodotto prodotto)
    {
        _prodotti.Add(prodotto);
    }

public void RimuoviProdotto(int id)
{
    foreach (var prodotto in _prodotti.ToList())
    {
        if (prodotto.Id == id)
        {
            _prodotti.Remove(prodotto);
        }
    }
}
public Prodotto CercaProdotto(int id)
{
    foreach (var prodotto in _prodotti)
    {
        if (prodotto.Id == id)
        {
            return prodotto;
        }
    }
    return null;
}
public List<Prodotto> VisualizzaProdotti()
    {
        return _prodotti;
    }
}