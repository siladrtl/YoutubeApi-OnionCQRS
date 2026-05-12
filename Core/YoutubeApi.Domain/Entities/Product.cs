using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;

namespace YoutubeApi.Domain.Entities
{
    public class Product: EntityBase
    {
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public required decimal Discount { get; set; }  
        public int BrandId { get; set; }
        public Brand Brand { get; set; }

        // Bir kategorinin birden fazla ürünü olabilir, otomatik olarak oluşturulan bir ilişki tablosu ile ilişkilendirilir
        public ICollection<Category> Categories { get; set; }

        // public required string ImagePath { get; set; }   
    }
}
