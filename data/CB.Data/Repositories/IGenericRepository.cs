using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Repositories
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetFirstAsync(string sql, object? parameters = null);
		Task<IEnumerable<T>> GetListAsync(string sql, object? parameters = null);
		Task<int> InsertSingleEntity(string query, T entity);
	}
}
