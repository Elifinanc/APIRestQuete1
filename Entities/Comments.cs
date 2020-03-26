using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete1APIrest
{
    public class Comments
    {
        /*public int commentId { get; set; }
        public string commentAuthor { get; set; }
        public string description { get; set; }*/

        public int postId { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string body { get; set; }
    }
}
