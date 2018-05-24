namespace dotnet_core_elasticsearch.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string description, Category category, decimal price)
        {
            this.Name = name;
            this.Description = description;
            this.Category = category;
            this.Price = price;
        }
    }
}