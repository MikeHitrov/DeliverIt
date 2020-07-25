namespace DeliverIt.Data
{
    using System;

    public class Meal
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public Image Image { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public TimeSpan TimeToPrepare { get; set; }
    }
}