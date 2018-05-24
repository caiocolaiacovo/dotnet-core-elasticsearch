using System.Collections.Generic;

namespace dotnet_core_elasticsearch.Domain.Entities
{
    public class Category : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}