﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewComboBox.Models
{
    public class Books
    {
        public string BookID { get; set; }
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public string BookType { get; set; }

        public Books() 
        { 
        
        }

        public Books(string bookID, string bookTitle, string bookDescription, string bookType)
        {
            BookID = bookID;
            BookTitle = bookTitle;
            BookDescription = bookDescription;
            BookType = bookType;
        }
    }
}
