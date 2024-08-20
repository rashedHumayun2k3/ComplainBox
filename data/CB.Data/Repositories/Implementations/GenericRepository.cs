using Dapper;
using CB.Data.Context;
using CB.Data.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Repositories.Implementations
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		public readonly EcDbContext _context;
		
		public GenericRepository(EcDbContext context)
        {
            _context = context;
		}
        public async Task<T> GetFirstAsync(string sql, object? parameters = null)
		{
			using var con = _context.CreateConnection();
			con.Open();
			var result = await con.QueryFirstOrDefaultAsync<T>(sql, parameters);
			return result;
		}

		public async Task<IEnumerable<T>> GetListAsync(string sql, object? parameters = null)
		{
			using var con = _context.CreateConnection();
			con.Open();
			var result = await con.QueryAsync<T>(sql, parameters);
			return result;
		}
		public async Task<int> InsertSingleEntity(string query, T entity)
		{
			using var con = _context.CreateConnection();
			con.Open();
			int rowsEffected = await con.ExecuteAsync(query, entity);
			return rowsEffected;
		}
	}
}
