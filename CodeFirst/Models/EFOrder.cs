using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class EFOrder
    {
        [Key]
        public int OrderId { get; set; }

        public int CustomerID { get; set; }

        public int EmpID { get; set; }

        public DateTime OrderDate { get; set; }

    }
}
