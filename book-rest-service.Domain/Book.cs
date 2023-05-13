﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_rest_service.Domain
{
    public class Book
    {
        public int id { get; set; }
        public string title { get; set; }
        public string? description { get; set; }
        public string? author { get; set; }
    }
}
