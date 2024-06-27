using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Supplier
    {
        [Key]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "Supplier name is required")]
        [StringLength(100, ErrorMessage = "Supplier name cannot exceed 100 characters")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Supplier address is required")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Supplier number is required")]
        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Number { get; set; }


        [Required(ErrorMessage = "Supplier email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Number")]
        public string Email { get; set; }
    }
}
