using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandex.Cargo.Models {
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "From must be between 5 and 15 characters")]
        public string Login {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "From must be between 8 and 15 characters")]
        public string Password {
            get; set;
        }

        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Type {
            get; set;
        }

        [EmailAddress(ErrorMessage = "Invalid email address")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "From must be between 5 and 25 characters")]
        public string Email {
            get; set;
        }
    }
}