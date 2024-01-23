using System;

namespace ProductSearchDemoApplication.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
    public class ProductViewModel
    {
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
