using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Data.Entities
{
	public class Product : BaseEntity
	{
        [BsonId]
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string ProductHighlights { get; set; }
        public string DetailContent { get; set; }
        public string ModelSpecification { get; set; }

        public string Thumbnail { get; set; }

        public string Description { get; set; }
        
    }

    

}
