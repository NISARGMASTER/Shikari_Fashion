using FsCheck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shikari_Fashion.Entities
{
    // here we  inherit from BaseEntity class . here Category is a child entity.
     public class Category : BaseEntity 
    {
        
        // Here we have multiple Products in one Category. so, we use List<> element.
        public List<Product> Products { get; set; }






    }
}
