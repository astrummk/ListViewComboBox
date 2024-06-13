using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewComboBox.Models
{
    public class BookType
    {
        public string BookTypeDesc { get; set; }
        public List<Books> Books { get; set; }

        public BookType(string bookDesc, List<Books> books)
        {
            BookTypeDesc = bookDesc;
            Books = books;
        }

        public BookType() 
        { 
        }
    }
}
