using System;
using System.Collections.Generic;

namespace DemoGeneric.Domain.Models
{
    public partial class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid CategoryId { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual Detail? Detail { get; set; }
    }
}
