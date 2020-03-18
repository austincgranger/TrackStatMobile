using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackStatMobile.Models;
using TrackStatMobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace TrackStatMobile.Views
{
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {

        HomeViewModel viewModel;
        public HomePage(User thisUser)
        {
            InitializeComponent();

            viewModel = new HomeViewModel(thisUser);
            BindingContext = viewModel;
            Shell.SetNavBarIsVisible(this, false);
        }
    }
}