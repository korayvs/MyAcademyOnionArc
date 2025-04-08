﻿namespace Onion.Domain.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IList<Product> Products { get; set; }
    }
}
