using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface IBaseRepository<TEntity,TEntityID> : IAttach<TEntity>, IEdit<TEntity>, IDelete<TEntityID>, IToList<TEntity, TEntityID> , ITransaction
    {
    }
}
