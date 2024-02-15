using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class EFOrderDetail
    {
        [Key]
        public int OrderDetailID { get; set; }

        public int OrderID { get; set; }
        public int PropID { get; set; }
        public int Quantity { get; set; }
        public EFOrder Order { get; set; }
    }
}
