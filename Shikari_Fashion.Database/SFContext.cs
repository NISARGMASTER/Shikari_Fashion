using Shikari_Fashion.Entities; 
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shikari_Fashion.Database
{
    public class SFContext : DbContext //it is a entity framework class. and we inherit this.
    {
        public SFContext() : base("ShikariFashionConnection") // "ShikariFashionConnection" is ConnectionStrings of DB.
        { 

        }


        public DbSet<Category> Categories { get; set;}// referance from SF.entities
        public DbSet<Product> products { get; set; }// referance from SF.entities
    }
}
