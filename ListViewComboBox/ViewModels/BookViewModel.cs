using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using ListViewComboBox.Models;
using MvvmHelpers;


namespace ListViewComboBox.ViewModels
{
    public class BookViewModel : ObservableRangeCollection<ProduktViewModel>, INotifyPropertyChanged
    {
        private bool _expanded;
        public BookType BookType { get; set; }
        public string BookTypeDesc { get { return BookType.BookTypeDesc; } }

        private ObservableRangeCollection<ProduktViewModel> grupaProdukti = new ObservableRangeCollection<ProduktViewModel>();

        public BookViewModel(BookType grupa, bool expanded = false)
        {
            this.BookType = grupa;
            this._expanded = expanded;

            foreach (Books produkt in BookType.Books)
            {
                grupaProdukti.Add(new ProduktViewModel(produkt));
            }

            if (expanded) { this.AddRange(grupaProdukti); }

        }

        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Expanded"));
                    OnPropertyChanged(new PropertyChangedEventArgs("StateIcon"));
                    if (_expanded)
                    {
                        this.AddRange(grupaProdukti);
                    }
                    else
                    {
                        this.Clear();
                    }

                }
            }

        }


    }
}
