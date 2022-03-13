using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Dtos
{
    public partial class Supplier
    {
        //public Supplier()
        //{
        //    Services = new HashSet<Service>();
        //}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? Created { get; set; }

        public virtual ICollection<Service> Services { get; set; }
    }
}
