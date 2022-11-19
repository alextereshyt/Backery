namespace Backery.Models
{
    public class Product
    {
        public int id { get; set; }

        public string name { get; set; }

        public int price { get; set; }


        public Product() { }
        public Product(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
       

        }
    }

}