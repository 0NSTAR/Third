using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandex.Cargo.Models {
    public class Order {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "'From' must be between 3 and 20 characters")]
        public string From {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "'To' must be between 3 and 20 characters")]
        public string To {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "'Type' must be between 3 and 20 characters")]
        public string Type {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        public DateTime Date {
            get; set;
        }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 100 characters")]
        public string? Description {
            get; set;
        }

        //[Required]
        public int UserId {
            get; set;
        }
    }
}