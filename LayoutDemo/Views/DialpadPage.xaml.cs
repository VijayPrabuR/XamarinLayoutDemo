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

    public partial class DialpadPage : ContentPage
    {
        public DialpadPage()
        {
            InitializeComponent();
        }
        private void Number_Entered(object sender, EventArgs e)
        {
            var enteredNumber = (sender as Button).Text;
            this.phoneNumber.Text += enteredNumber;
        }
        private void Number_Deleted(object sender, EventArgs e)
        {
            this.phoneNumber.Text = null;
        }
    }
}