using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ListViewComboBox.Models;
using Xamarin.Forms;

namespace ListViewComboBox.ViewModels
{
    public class MainBookViewModel : BaseViewModel
    {
        public static ObservableCollection<BookType> booksList = new ObservableCollection<BookType>();
        public ObservableCollection<BookType> bookType;

        public Command<BookViewModel> RefreshItemsCommand { get; set; }

        private BookViewModel _oldGrupa;

        private ObservableCollection<BookViewModel> items;
        public ObservableCollection<BookViewModel> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }


        public Command LoadGrupaCommand { get; set; }
        public MainBookViewModel()
        {
            items = new ObservableCollection<BookViewModel>();
            Items = new ObservableCollection<BookViewModel>();

            bookType = new ObservableCollection<BookType>();
            LoadGrupaCommand = new Command(async () => await ExecuteLoadItemsCommandAsync());
            RefreshItemsCommand = new Command<BookViewModel>((item) => ExecuteRefreshItemsCommand(item));
        }

        async System.Threading.Tasks.Task ExecuteLoadItemsCommandAsync()
        {
            //ExecuteLoadItemsCommandAsync()

            List<BookType> booksList = new List<BookType>();
            List<Books> books = new List<Books>(); 

            books.Add(new Books("11", "New Cooker", "Health mediteranian food", "1"));
            books.Add(new Books("22", "Last Cooker", "Health mediteranian food", "1"));
            booksList.Add(new BookType("Mediteranian Cooker", books));
            //books.Clear();

            List<Books> books2 = new List<Books>();
            books2.Add(new Books("33", "Save Yourself", "Comedy", "2"));
            books2.Add(new Books("44", "So Lucky", "Comedy", "2"));
            booksList.Add(new BookType("Comedy", books2));
            //books.Clear();


            if (booksList != null && booksList.Count > 0)
            {
                foreach (var grupa in booksList)
                    Items.Add(new BookViewModel(grupa));
            }
            else { IsEmpty = true; }

        }

        private void ExecuteRefreshItemsCommand(BookViewModel item)
        {

            if (_oldGrupa == item)
            {
                // click twice on the same item will hide it
                item.Expanded = !item.Expanded;
            }
            else
            {
                if (_oldGrupa != null)
                {
                    // hide previous selected item
                    _oldGrupa.Expanded = false;
                }
                // show selected item
                item.Expanded = true;
            }

            _oldGrupa = item;
        }
    }
}
