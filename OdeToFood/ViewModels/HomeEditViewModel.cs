using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.ViewModels
{
    public class HomeEditViewModel
    {
        [Required,MaxLength(80)]
        public string Name { get; set; }
        [Required]
        public CuisineType Cuisine { get; set; }
    }
}
