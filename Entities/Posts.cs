using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete1APIrest
{
    public class Posts
    {
        /*public int postId { get; set; }
        public string postAuthor { get; set; }
        public string url { get; set; }
        public List <Comments> postComments {get; set; }*/
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}
