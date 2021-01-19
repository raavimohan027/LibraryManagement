using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Category { get; set; }

        public string Status { get; set; }

        public List<string> Reviews { get; set; }

        public List<string> Authors { get; set; }
    }
}
