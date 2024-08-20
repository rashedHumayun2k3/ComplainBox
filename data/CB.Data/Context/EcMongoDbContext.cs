using CB.Data.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Context
{
	public class EcMongoDbContext
	{
		private readonly IMongoDatabase _database;
		public EcMongoDbContext(IOptions<MongoDbConfig> config)
        {
			var client = new MongoClient(config.Value.ConnectionString);
			_database = client.GetDatabase(config.Value.DatabaseName);
		}
		public IMongoCollection<Product> Products => _database.GetCollection<Product>("products");
	}
}
