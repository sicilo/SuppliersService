using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    interface ICountriesPerServiceService<TEntity, TEntityID> : IAdd<TEntity>, IDelete<TEntityID>, IToList<TEntity, TEntityID>
    {
    }
}
