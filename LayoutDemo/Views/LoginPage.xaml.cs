using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LayoutDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        async void gotoDialpadPage(object sender, EventArgs e)
        {
            string user = username.Text;
            string pass = password.Text;
            if(String.IsNullOrEmpty(user) || String.IsNullOrEmpty(pass))
            {
                await DisplayAlert("Failure msg", "Enter credentials", "OK");
            }
            else
            {
                await Navigation.PushAsync(new DialpadPage());
            }
            
        }
    }
}