using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewComboBox.ViewModels;
using ListViewComboBox.Views;

namespace ListViewComboBox
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Main(new MainBookViewModel());
            //Glavna(new GrupaGroupViewModels())

            //MainPage = new Main(new MainBookViewModels());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
