using CB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Repositories
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetAllProducts(string dynamicSearchingQuery);
        Task<Product> GetProductById(int id);
    }
}
