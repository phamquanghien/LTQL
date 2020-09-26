using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL.Models
{
    [Table("Roles")]
    public class Role
    {
        [Key]
        [MaxLength(20)]
        public string RoleID { get; set; }
        public string RoleName { get; set; }
    }
}