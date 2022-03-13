using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Dtos
{
    public partial class CountriesPerService
    {
        public int Id { get; set; }
        public int? IdService { get; set; }
        public string Name { get; set; }

        public virtual Service IdServiceNavigation { get; set; }
    }
}
