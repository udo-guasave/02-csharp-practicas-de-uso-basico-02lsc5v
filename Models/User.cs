using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _02_csharp_primeros_pasos.Models
{
    public enum gender {
        FEMENINO, MASCULINO
    }

    [Table("users")]
    public class User
    {
        public int Id { get; set; }
        
        [Required, MaxLength(16)]
        public string Name { get; set; }

        [Required, MaxLength(200)]
        public string Password { get; set; }

        [Required, MaxLength(50)]
        public string Firstname { get; set; }

        [Required, MaxLength(50)]
        public string Lastname { get; set; }

        [Required, MaxLength(200)]
        public string Email { get; set; }

        [MaxLength(200)]
        public string RememberToken { get; set; }

        [Required]
        public gender Gender { get; set; }

        [Required]
        public int RoleId { get; set; }


        // Controlada por EFCore
        public Role Role { get; set; }

    }
}