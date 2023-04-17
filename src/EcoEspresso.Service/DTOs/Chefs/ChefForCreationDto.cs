using EcoEspresso.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoEspresso.Service.DTOs.Chefs
{
    public class ChefForCreationDto
    {
        [Required(ErrorMessage = "FirstName is required")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "LastName is required")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Salary is required")]
        public decimal Salary { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; } = string.Empty;

    }

}
