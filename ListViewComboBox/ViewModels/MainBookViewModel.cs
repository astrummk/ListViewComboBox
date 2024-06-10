using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ListViewComboBox.Models;

namespace ListViewComboBox.ViewModels
{
    public class MainBookViewModel : BaseViewModel
    {
        public static ObservableCollection<Books> books = new ObservableCollection<Books>();

        public MainBookViewModel()
        {

        }

    }
}
