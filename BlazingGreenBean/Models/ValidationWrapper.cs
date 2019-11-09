using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingGreenBean.Models
{

    public class ValidationWrapper
    {
        [Required]
        [RegularExpression("[a-zA-Z0-9!_\"'&* ]+", ErrorMessage ="Name can only contain letters, numbers, spaces, and \"'_&!*")]
        public string Name { get; set; }
    }
}
