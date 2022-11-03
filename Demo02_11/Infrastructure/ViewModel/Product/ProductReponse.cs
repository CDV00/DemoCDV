using Demo02_11.Infrastructure.ViewModel.Category;
using Demo02_11.Infrastructure.ViewModel.Detail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Infrastructure.ViewModel.Product
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
