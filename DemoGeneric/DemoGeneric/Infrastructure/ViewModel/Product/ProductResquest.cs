using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Infrastructure.ViewModel.Product
{
    public class ProductResquest
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public virtual Guid? DetailId { get; set; }
    }
}
