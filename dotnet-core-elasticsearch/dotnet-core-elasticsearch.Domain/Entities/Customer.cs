using System;

namespace dotnet_core_elasticsearch.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public int CustomerId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DocumentId { get; private set; }
        public string Email { get; private set; }
        public string StreetAddress { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }

        public Customer(string firstName, string lastName, string documentId, string email, string streetAddress,
            string city, string state, string zipCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DocumentId = documentId;
            this.Email = email;
            this.StreetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public bool IsVIPCustomer(Customer customer)
        {
            return DateTime.Now.Year - customer.CreatedAt.Year >= 5;
        }
    }
}