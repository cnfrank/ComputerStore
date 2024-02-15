namespace WebApplicationMVC.Models
{
    public class Desktop : Laptop
    {
        

        public int Screen { get; set; }

        public int Weight { get; set; }

        public Desktop(string name, decimal price, int rAM, int screen, int weight) : base(name, price, rAM)
        {
            Screen = screen;
            Weight = weight;
        }


    }
}
