using System;
using System.Collections.Generic;

#nullable disable

namespace Infraestructure.Migrations
{
    public partial class Service
    {
        public Service()
        {
            CountriesPerServices = new HashSet<CountriesPerService>();
        }

        public int Id { get; set; }
        public int? IdSupplier { get; set; }
        public string Name { get; set; }
        public decimal? ValuePerHour { get; set; }
        public DateTime? Created { get; set; }

        public virtual Supplier IdSupplierNavigation { get; set; }
        public virtual ICollection<CountriesPerService> CountriesPerServices { get; set; }
    }
}
