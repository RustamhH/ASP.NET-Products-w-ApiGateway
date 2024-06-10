using Database.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities.Concretes
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
