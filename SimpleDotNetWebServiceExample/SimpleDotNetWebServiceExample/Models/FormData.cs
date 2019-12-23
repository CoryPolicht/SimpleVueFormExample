using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleDotNetWebServiceExample.Models
{
    public class FormData
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        public override string ToString()
        {
            return Name + " " + Email;
        }
    }
}
