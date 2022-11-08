using DemoGeneric.Infrastructure.ViewModel.Category;
using DemoGeneric.Infrastructure.ViewModel.Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Infrastructure.ViewModel.Product
{
    public class ProductReponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryReponse Category { get; set; }
        public virtual Guid? DetailId { get; set; }
        public virtual DetailReponse? Detail { get; set; }
    }
}
