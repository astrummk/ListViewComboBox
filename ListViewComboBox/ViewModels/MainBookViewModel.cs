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
        public static ObservableCollection<Books> books = new ObservableCollection<Books>();

        public Command LoadGrupaCommand { get; set; }
        public MainBookViewModel()
        {
            LoadGrupaCommand = new Command(async () => await ExecuteLoadItemsCommandAsync());
        }

        async System.Threading.Tasks.Task ExecuteLoadItemsCommandAsync()
        {

            IList<Books> books = new List<Books>();

            books.Add(new Books("1","Sweet Cooker", "Bake sweets", "1"));
            books.Add(new Books("2", "Mediteranian Cooker", "Health mediteranian food", "1"));
            books.Add(new Books("3", "Save Yourself", "Comedy", "2"));
            books.Add(new Books("4", "So Lucky", "Comedy", "2"));





        }
    }
}
