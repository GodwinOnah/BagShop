using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.AutoMapperAndUrl;
using API.DTOs;
using AutoMapper;
using core.Controllers;
using core.Entities;

namespace API.AutoMapper
{
    public class MappingProductProfile : Profile//this code removes the null property of product brand and types
    {
        public MappingProductProfile()
        {
            CreateMap<Products, ProductsShapedObject>()
            .ForMember(x=>x.productBrand,y=>y.MapFrom(z=>z.productBrand.Name))
            .ForMember(x=>x.productType,y=>y.MapFrom(z=>z.productType.Name))
            .ForMember(x=>x.prodPicture,y=>y.MapFrom<ProductPictureUrl>());
        }
    }
}