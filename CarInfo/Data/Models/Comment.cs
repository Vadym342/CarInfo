using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarInfo.Data.Models
{
    public class Comment
    {
        public int id { get; set; }
        public string message { get; set; }

        public int rating { get; set; }

        public int countLike { get; set; }

        public int countDisLike { get; set; }
    }
}
