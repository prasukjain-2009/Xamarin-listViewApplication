using System;
using System.Collections.Generic;
using ListView.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryPage : ContentPage
    {
        EntryPageViewModel vm;
        public EntryPage()
        {
            InitializeComponent();
            vm = new EntryPageViewModel();
            BindingContext = vm;
        }
        private void AddEntry(object sender, EventArgs e)
        {
            Console.WriteLine("IN ADDENTRY");
            vm.AddToPeople();
            Navigation.PushAsync(new MainPage());
        }
    }

}
