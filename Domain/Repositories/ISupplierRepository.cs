using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ISupplierRepository
    {
        void Create(Supplier carEntitie);
        void Update(Supplier carEntitie);
        void Delete(int id);
        Supplier GetSupplier(int id);
        List<Supplier> GetSuppliers();
    }
}
