using System;
using System.Linq;
using System.Threading.Tasks;

namespace Demo02_11.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        /*public virtual Guid? DetailId { get; set; }
        public virtual Detail Detail { get; set; }*/
        
    }
}
