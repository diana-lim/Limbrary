using System;
using System.Collections.Generic;

namespace Limbrary
{
    public partial class Books
    {
        public int BooksId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string AgeGroup { get; set; }
        public int? InStock { get; set; }
    }
}
