using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public int? IdSupplier { get; set; }
        public string Name { get; set; }
        public decimal? ValuePerHour { get; set; }
        public DateTime? Created { get; set; }
        public virtual Supplier IdSupplierNavigation { get; set; }

    }
}
