using System.Collections.Generic;

namespace DeliverIt.Data
{
    public class Order
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public User Customer { get; set; }

        public string DelivererId { get; set; }

        public User Deliverer { get; set; }

        public List<Meal> Items { get; set; }

        public string CompanyId { get; set; }

        public Company Company { get; set; }

        public decimal TotalPrice { get; set; }
    }
}