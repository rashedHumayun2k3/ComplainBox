using AutoMapper;
using CB.Business.Dto.Response;
using CB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Business.Mappers
{
	public class ProductMapper : Profile
	{
		public ProductMapper() 
		{
			CreateMap<Product, ProductDto>()
             .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Name))
			 .ForMember(dest=>dest.ProductHighlights, opt=> opt.MapFrom(src=>src.ProductHighlights))
             .ForMember(dest => dest.DetailContent, opt => opt.MapFrom(src => src.DetailContent))
             .ForMember(dest => dest.ModelSpecification, opt => opt.MapFrom(src => src.ModelSpecification))
			 .ForMember(dest=>dest.Thumbnail, opt=> opt.MapFrom(src=>src.Thumbnail))
             .ReverseMap();

        }
	}
}
