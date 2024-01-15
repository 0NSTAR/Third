using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandex.Cargo.Models {
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {
            get; set;
        }
        [Required]
        public string Type {
            get; set;
        }
        [Required]
        public string Login {
            get; set;
        }
        [Required]
        public string Password {
            get; set;
        }
    }
}