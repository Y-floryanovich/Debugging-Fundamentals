namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if(obj == null)return false;
            if (obj.GetType() != this.GetType()) return false;

            Product product = (Product)obj;
            if (product.Name == this.Name && product.Price == this.Price)
            {
                return true;
            }
            return false;
        }
    }
}
