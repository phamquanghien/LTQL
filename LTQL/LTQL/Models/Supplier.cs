using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL.Models
{
    [Table("Suppliers")]
    public class Supplier
    {
        [Key]
        [MaxLength(20)]
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}