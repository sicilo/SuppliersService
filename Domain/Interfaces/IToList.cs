using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IToList<TEntity,TEntityID>
    {
        List<TEntity> ToList();
        TEntity SelectById(TEntityID entityId);
    }
}
