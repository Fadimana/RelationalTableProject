using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.cs.Entity
{
    public class Blog //principal
    {
        public Blog()
        {
            Posts = new HashSet<Post>();
        }
        public int id { get; set; }
        public string? name { get;set; }

        public ICollection<Post>? Posts { get; set; }


    }
}
