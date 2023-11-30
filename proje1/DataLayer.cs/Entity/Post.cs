using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataLayer.cs.Entity
{
    public class Post //depented
    {
        public int id { get; set; }
        public string? title { get; set; }
        public int BlogId { get; set; } 

        [JsonIgnore]
        public Blog? Blog { get; set; }

    }
}





















