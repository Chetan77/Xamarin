using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GreetingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmployeeInfo : ContentPage
    {
        public EmployeeInfo()
        {
            InitializeComponent();
        }

        private void OnSubmit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignInPage());
            DisplayAlert("submitted", "please log in with emp id and password","done");
        }
    }
}