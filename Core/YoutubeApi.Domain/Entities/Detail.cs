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
    public class Detail:EntityBase
    {
        public Detail()
        {
                
        }
        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }
        public required string Title  { get; set; }
        public required string Description { get; set; }

        // Bir detail bir Category'e bağlı
        public required int CategoryId { get; set; }
        public  Category Category { get; set; }

    }

}
