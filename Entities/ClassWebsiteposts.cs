using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete1APIrest.Entities
{
    public class ClassWebsiteposts
    {
        public string status { get; set; }

        public int count { get; set; }

        public int count_total { get; set; }

        public int pages { get; set; }

        public List<Posts> posts { get; set; }

        public Query query { get; set; }
    }
}
