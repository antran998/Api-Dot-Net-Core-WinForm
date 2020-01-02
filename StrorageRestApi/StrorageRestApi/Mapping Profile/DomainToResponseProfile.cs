using AutoMapper;
using Storage.Contracts.v1.Responses;
using StrorageRestApi.Contracts.v1.Responses;
using StrorageRestApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrorageRestApi.Mapping_Profile
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            CreateMap<ProductType, ProductTypeResponse>();
            CreateMap<Product, ProductResponse>()
                .ForMember(d => d.TypeId, o => o.UseDestinationValue());
            CreateMap<Bill, BillResponse>()
                .ForMember(d => d.TypeId, o => o.UseDestinationValue());
            CreateMap<BillDetail, BillDetailResponse>()
                .ForMember(d => d.BillId, o => o.UseDestinationValue());
        }
    }
}
