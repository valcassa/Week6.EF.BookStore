﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.EF.BookStore
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Quantity { get; set; }

    }
}
