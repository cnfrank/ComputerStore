namespace WebApplicationMVC.Models
{
    public class Laptop
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        private int _ram;

        public int RAM
        {
            get { return _ram; }
            set { _ram = value; }
        }

        public Laptop(string name, decimal price, int rAM)
        {
            Name = name;
            Price = price;
            RAM = rAM;
        }
    }
}
