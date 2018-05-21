using System;

namespace dotnet_core_elasticsearch.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DocumentId { get; set; }
        public string Email { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

        public bool IsVIPCustomer(Customer customer)
        {
            return DateTime.Now.Year - customer.CreatedAt.Year >= 5;
        }
    }
}