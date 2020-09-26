using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LTQL.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required(ErrorMessage = "Field can't be empty")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        public string PassWord { get; set; }
        [Required(ErrorMessage = "Field can't be empty")]
        [Compare("PassWord", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [NotMapped]
        public string ConfirmPassWord { get; set; }
        [MaxLength(20)]
        public string RoleID { get; set; }
        public bool IsActive { get; set; }
        public bool Status { get; set; }
    }
}