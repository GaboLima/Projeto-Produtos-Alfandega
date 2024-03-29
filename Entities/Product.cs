using System.Globalization;

namespace PRJProdutoImportacao.Entities
{
     class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public virtual string PriceTag() 
        {
            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
