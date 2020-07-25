namespace DeliverIt.Data
{
    using System.ComponentModel.DataAnnotations;
    using Microsoft.AspNetCore.Http;

    public class Image
    {
        [Key]
        public string Id { get; set; }
        public string Title { get; set; }

        public string Name { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}