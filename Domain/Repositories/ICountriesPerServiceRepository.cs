using Domain.Interfaces;
using Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public interface ICountriesPerServiceRepository<TEntity, TEntityID> : IAdd<TEntity>, IDelete<TEntityID>, IToList<TEntity, TEntityID> , ITransaction
    {
    }
}
