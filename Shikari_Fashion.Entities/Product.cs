using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shikari_Fashion.Entities
{
    // here we  inherit from BaseEntity class . here Product is a child entity.
    public class Product : BaseEntity
    {
       
        //Here we must specify which category the product belongs to in this case(Men,Women), we refer to the Category class via a class object.
        public Category Category { get; set; }
       
        // here we use decimal instead of float because it supports 18 number after point. decimal mostly used when we work with currency or finance .
        public decimal Price { get; set; }
    }
}
