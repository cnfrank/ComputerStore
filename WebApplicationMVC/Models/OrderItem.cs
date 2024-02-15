using System.ComponentModel.DataAnnotations;

namespace WebApplicationMVC.Models
{
    public class OrderItem
    {
        [Required(ErrorMessage ="Please pick a processor")]
        public String Processor { get; set; }

        [Required(ErrorMessage ="Please specify RAM")]
        [Range(8,32,ErrorMessage ="Value for {0} must be between {1} and {2}")]
        public int RAM { get; set; }

        public double Speed { get; set; }

        public double HDSize { get; set; }
        public String Email { get; set; }

        public OrderItem(string processor, int rAM, double speed, double hDSize, string email)
        {
            Processor = processor;
            RAM = rAM;
            Speed = speed;
            HDSize = hDSize;
            Email = email;
        }
    }
}
