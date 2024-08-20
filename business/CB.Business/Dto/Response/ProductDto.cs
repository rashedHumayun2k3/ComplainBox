using CB.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Business.Dto.Response
{
	public class ProductDto
	{
		public Guid? Id { get; set; }
		public string ProductName { get; set; } = string.Empty;
        public string Code { get; set; }
        public string ProductHighlights { get; set; } = string.Empty;
        public string DetailContent { get; set; } = string.Empty;
        public string ModelSpecification { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string Thumbnail { get; set; }=string.Empty;
     



    }
}
