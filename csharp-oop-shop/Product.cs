using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpoopshop
{
    public class Product
    {
        public string Code { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public byte Iva { get; set; }

        public Product(string name, string description, double price, byte iva)
        {
            Code = CreateCode();
            Name = name;
            Description = description;
            Price = price;
            Iva = iva;
        }

        public static string CreateCode()
        {
            var code = new Random().Next(0, 1000);

            return code.ToString().PadLeft(8, '0');
        }

        public double PriceIva()
        {
            var price_iva = (Price / (100 * 100)) * ((Iva + 100) * 100);

            return price_iva;
        }

        public string NameCode()
        {
            var result = $"{Code} | {Name}";

            return result;
        }

        public override string ToString()
        {
            var nl = Environment.NewLine;

            var productWrite =
                $"Nome prodotto: {Name}" + nl
                + $"Descrizione prodotto: {Description}" + nl
                + $"Prezzo prodotto: {Price} euro" + nl
                + $"IVA: {Iva}%" + nl
                + $"Prezzo + IVA: {PriceIva()} euro";

            return productWrite;
        }
    }
}
