using CB.Business.Dto.Response;
using CB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Business.Managers
{
	public interface IProductManager
	{
		Task<ProductDto> GetProductById(int id);
		Task<List<ProductDto>> GetProduct(string dynamicSearchingQuery);
     
	}
}
