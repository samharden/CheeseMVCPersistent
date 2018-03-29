using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCheeseViewModel
    {
        [Required]
        [Display(Name = "Cheese Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must give your cheese a description")]
        public string Description { get; set; }

        public CheeseType Type { get; set; }

        public List<SelectListItem> CheeseTypes { get; set; }

        public AddCheeseViewModel() {

            CheeseTypes = new List<SelectListItem>();

            // <option value="0">Hard</option>
            CheeseTypes.Add(new SelectListItem {
                Value = ((int) CheeseType.Goat).ToString(),
                Text = CheeseType.Goat.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Cow).ToString(),
                Text = CheeseType.Cow.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Cat).ToString(),
                Text = CheeseType.Cat.ToString()
            });

            CheeseTypes.Add(new SelectListItem
            {
                Value = ((int)CheeseType.Yak).ToString(),
                Text = CheeseType.Yak.ToString()
            });

        }
    }
}
