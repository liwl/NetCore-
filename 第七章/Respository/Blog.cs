﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 第七章.Respository
{
    public class Blog
    {
        public int BlogId { get; set; }

        public string Url { get; set; }

        public List<Post> Posts { get; set; }
    }
}
