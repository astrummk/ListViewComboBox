using System;
using System.Collections.Generic;
using System.Text;

using ListViewComboBox.Models;

namespace ListViewComboBox.ViewModels
{
    public class ProduktViewModel
    {

        private Books _produkt;

        public ProduktViewModel(Books produkt)
        {
            _produkt = produkt;
        }

        //pole na modelot
        public string BookTitle { get { return _produkt.BookTitle; } }

        public string BookID { get { return _produkt.BookID; } }

        public string BookType { get { return _produkt.BookType; } }

        //vraka new Product()
        public Books Produkt
        {
            get => _produkt;
        }


    }
}
