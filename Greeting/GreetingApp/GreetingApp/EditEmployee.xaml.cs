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
    public partial class EditEmployee : ContentPage
    {
        public EditEmployee()
        {
            InitializeComponent();
        }
        private void EmployeeEdit(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EmployeeInfo());
        }
    }
}