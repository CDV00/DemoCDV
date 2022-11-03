using Demo02_11.Infrastructure.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Infrastructure.ViewModel.Category
{
    public class CategoryReponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductReponse>? Products { get; set; }
    }
}
