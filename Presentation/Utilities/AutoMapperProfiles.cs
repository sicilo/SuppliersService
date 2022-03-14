using AutoMapper;
using Models.Dtos;
using Models.Entities;

namespace Presentation.Utilities
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<SupplierRequest,Supplier>();
            CreateMap<Supplier, SupplierResponse>();
        }
    }
}
