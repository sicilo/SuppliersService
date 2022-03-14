using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class SupplierRequest
    {
        [Required(ErrorMessage = "Name {0} is required")]
        [StringLength(maximumLength:30,ErrorMessage = "Name {0} xax length size : {1}")]
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
