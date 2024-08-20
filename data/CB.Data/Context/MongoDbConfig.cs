using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Context
{
	public class MongoDbConfig
	{
		public const string Position = "ConnectionStrings";
		public string ConnectionString { get; set; } = string.Empty;
		public string DatabaseName { get; set; } = string.Empty;
	}
}
