using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace ExercicioHerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double Customsfree { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customsfree)
            : base(name, price)
        {
            Customsfree = customsfree;
        }

      public double TotalPrice()
        {
            return Customsfree + Price;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Customs free: $ "
                + Customsfree.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
