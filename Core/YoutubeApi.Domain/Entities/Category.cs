using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Common;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Domain.Entities
{
    

    public class Category : EntityBase, IEntityBase
    {

        public Category()
        {
                
        }
        public Category(int parentId, string name, int priorty )
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public required int ParentId { get; set; }
        public required string Name { get; set; }
        public required int Priorty { get; set; }

        // Bir Category'nin birden fazla Detail'i olabilir
        public ICollection<Detail> Details { get; set; }

        // Bir Category'nin birden fazla Product'u olabilir, otomatik olarak oluşturulan bir ilişki tablosu ile ilişkilendirilir
        public ICollection<Product> Products { get; set; }  
    }
}


