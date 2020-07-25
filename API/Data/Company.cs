namespace DeliverIt.Data
{
    using System.Collections.Generic;

    public class Company
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public List<Meal> Menu { get; set; }

        public int Rating { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longtitude { get; set; }
    }
}