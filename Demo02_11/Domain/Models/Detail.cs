using System;

namespace Demo02_11.Domain.Models
{
    public class Detail
    {
        public Guid Id { get; set; }
        public string DetailA { get; set; }
        public string DetailB { get; set; }
        public Guid ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
