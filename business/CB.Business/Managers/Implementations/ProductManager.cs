using AutoMapper;
using CB.Business.Dto.Response;
using CB.Data.Entities;
using CB.Data.Repositories;
using CB.Data.Repositories.Implementations;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Business.Managers.Implementations
{
	public class ProductManager : IProductManager
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;
		private readonly ILogger<ProductManager> _logger;

		public ProductManager(IProductRepository productRepository, IMapper mapper, ILogger<ProductManager> logger)
        {
			_productRepository = productRepository;
			_mapper = mapper;
			_logger = logger;
		}

		public async Task<ProductDto> GetProductById(int id)
		{
			//throw new ArgumentNullException("UserId can not be null");
			_logger.LogInformation("GetProductById ({id})",id);
			// hellos
			var result = _mapper.Map<ProductDto>(await _productRepository.GetProductById(id));
			return result;
		}

        
	


		
        public async Task<List<ProductDto>> GetProduct(string dynamicSearchingQuery)
		{
            var result = _mapper.Map<List<ProductDto>>(await _productRepository.GetAllProducts(dynamicSearchingQuery));
			return result.ToList();

        }

      
	}
}
