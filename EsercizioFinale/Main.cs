using System;

/// <summary>
/// Classe principale del programma Magazzino.
/// </summary>
public class Program
{
    /// <summary>
    /// Metodo principale che gestisce il menu e le operazioni del magazzino.
    /// </summary>
    public static void Main(string[] args)
    {
        bool esci = false; // Flag per uscire dal ciclo principale
        IProdotto prodotto; // Variabile per i prodotti creati
        var magazzino = Magazzino.Istanza; // Singleton del magazzino

        Console.WriteLine("Benvenuto nel Magazzino! Cosa vuoi fare?");
        do
        {
            // Stampa il menu delle opzioni
            Console.WriteLine("[1] Aggiungi prodotto Igiene");
            Console.WriteLine("[2] Aggiungi prodotto Alimentare");
            Console.WriteLine("[3] Aggiungi prodotto Elettronica");
            Console.WriteLine("[4] Visualizza prodotti");
            Console.WriteLine("[5] Cerca prodotto nel magazzino");
            Console.WriteLine("[6] Ordina prodotto");
            Console.WriteLine("[0] Esci");

            string scelta = Console.ReadLine(); // Legge la scelta dell'utente

            switch (scelta)
            {
                case "1":
                    // Crea e aggiunge un prodotto di Igiene
                    prodotto = ProdottoFactory.CreaProdotto(scelta);
                    magazzino.AggiungiProdotto(prodotto);
                    Console.WriteLine("Prodotto Igiene aggiunto al magazzino.");
                    break;
                case "2":
                    // Crea e aggiunge un prodotto Alimentare
                    prodotto = ProdottoFactory.CreaProdotto(scelta);
                    magazzino.AggiungiProdotto(prodotto);
                    Console.WriteLine("Prodotto Alimentare aggiunto al magazzino.");
                    break;
                case "3":
                    // Crea e aggiunge un prodotto di Elettronica
                    prodotto = ProdottoFactory.CreaProdotto(scelta);
                    magazzino.AggiungiProdotto(prodotto);
                    Console.WriteLine("Prodotto Elettronica aggiunto al magazzino.");
                    break;
                case "4":
                    // Visualizza tutti i prodotti presenti nel magazzino
                    magazzino.VisualizzaProdotti();
                    break;
                case "5":
                    // Cerca un prodotto per nome
                    Console.WriteLine("Inserisci il nome del prodotto da cercare:");
                    string nomeProdotto = Console.ReadLine();
                    magazzino.CercaProdotto(nomeProdotto);
                    break;
                case "6":
                    // Funzionalità di ordinazione prodotto
                    Console.WriteLine("Inserisci quale prodotto ordinare:");
                    break;
                case "0":
                    // Esce dal programma
                    esci = true;
                    Console.WriteLine("Grazie per aver utilizzato il Magazzino. Arrivederci!");
                    break;
                default:
                    // Gestisce scelte non valide
                    Console.WriteLine("Scelta non valida, riprova.");
                    break;
            }
        } while (!esci); // Continua finché l'utente non sceglie di uscire
    }
}