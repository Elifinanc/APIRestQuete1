using Quete1APIrest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete1APIrest
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public Address address { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
        public Company company { get; set; }

        //public List <Posts> userPosts { get; set; }
        //public List <Albums> userAlbums { get; set; }
        //public List <Comments> userComments { get; set; }
    }
}
