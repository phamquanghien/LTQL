using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL.Models
{
    [Table("Products")]
    public class Product
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        [MaxLength(10)]
        public string Unit { get; set; }
        [MaxLength(20)]
        public string SupplierID { get; set; }
    }
}