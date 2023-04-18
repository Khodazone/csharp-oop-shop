/* Creare la classe Prodotto che gestisce i prodotti dello shop.
 * Un prodotto è caratterizzato da:
 * - codice (numero intero)
 * - nome
 * - descrizione
 * - prezzo
 * - iva
 * Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter (o eventualmente le properties) ed eventuali altri metodi di “utilità” per fare in modo che:
 * Alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
 * Il codice prodotto sia accessibile solo in lettura
 * Gli altri attributi siano accessibili sia in lettura che in scrittura
 * Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
 * Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
 */

using csharpoopshop;

Console.WriteLine("Numero prodotti:");
int productsNum = Convert.ToInt32(Console.ReadLine());

Product[] products = new Product[productsNum];

for (int i = 0; i < productsNum; i++)
{
    Console.WriteLine($"Inserire nome prodotto {i + 1}:");
    string name = Console.ReadLine();

    Console.WriteLine($"Inserire descrizione prodotto {i + 1}:");
    string description = Console.ReadLine();

    Console.WriteLine($"Inserire prezzo prodotto {i + 1}:");
    double price = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine($"Inserire iva prodotto {i + 1}:");
    byte iva = (byte)Convert.ToInt32(Console.ReadLine());


    Product _object = new Product(name, description, price, iva);

    products[i] = _object;
}


Console.WriteLine("LISTA PRODOTTI:");

for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine(products[i].ToString());
}