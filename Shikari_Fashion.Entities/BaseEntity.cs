using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shikari_Fashion.Entities
{
    // Here, we use one class for common elements shared by all entities And this is the concept of INHERITANCE.
    // Here BaseEntity is a perent entity.
    public class BaseEntity 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
