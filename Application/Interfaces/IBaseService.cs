using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    interface IBaseService<TEntity, TEntityID> : IAttach<TEntity> , IEdit<TEntity>, IDelete<TEntityID>, IToList<TEntity, TEntityID>
    {
    }
}
