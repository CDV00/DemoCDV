using DemoGeneric.Infrastructure.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Infrastructure.ViewModel.Detail
{
    public class DetailReponse
    {
        public Guid Id { get; set; }
        public string DetailA { get; set; }
        public string DetailB { get; set; }
        public Guid ProductId { get; set; }
        public ProductReponse Product { get; set; }

    }
}
