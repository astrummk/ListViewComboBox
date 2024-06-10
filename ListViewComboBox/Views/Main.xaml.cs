using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewComboBox.Models;
using ListViewComboBox.ViewModels;

namespace ListViewComboBox.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        private MainBookViewModel ViewModel
        {
            get { return (MainBookViewModel)BindingContext; }
            set { BindingContext = value; }
        }

        public Main(MainBookViewModel viewModel)
        {
            InitializeComponent();
            this.ViewModel = viewModel;
        }

        public Main()
        {
            InitializeComponent();
        }
        
        private void BookID_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                //var obj = (Poracka)e.SelectedItem;
                //var PartnerIme = obj.PorackaID.ToString();

                //ViewModel.PorackaIzbor = PartnerIme;
            }
            catch { }
        }

        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                //vcituvanje na App.config
                //string userid = PCLAppConfig.ConfigurationManager.AppSettings["UserID"];

                //if (ViewModel.Items.Count == 0)
                //{
                //    ViewModel.LoadGrupaCommand.Execute(null);
                //    ViewModel.LoadPorackaCommand.Execute(null);
                //}
            }
            catch (Exception ex)
            {

            }
        }


    }
}