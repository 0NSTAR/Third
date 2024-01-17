using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Yandex.Cargo.Models {
    public class Order {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        public string State { get; set; } = "in processing";

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "'From' must be between 3 and 20 characters")]
        public string From { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "'To' must be between 3 and 20 characters")]
        public string To { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(10, ErrorMessage = "'Type' must be selected")]
        public string Type { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Description must be between 10 and 100 characters")]
        public string Description { get; set; }
    }
}