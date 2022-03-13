using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}