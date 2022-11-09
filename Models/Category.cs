using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PROJEKT.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name = "Category name")]
        [Required(ErrorMessage = "The category name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
