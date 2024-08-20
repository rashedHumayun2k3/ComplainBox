using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Context
{
	public class EcDbContext
	{
		private ConnectionStringOptions connectionStringOptions;
		public EcDbContext(IOptionsMonitor<ConnectionStringOptions> optionsMonitor)
		{
			connectionStringOptions = optionsMonitor.CurrentValue;
		}
		public IDbConnection CreateConnection() => new SqlConnection(connectionStringOptions.SqlConnection);
	}
}
