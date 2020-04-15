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
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            slide.Value = 0.1;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("click", "you are greet", "done");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            slideValue.Text = string.Format("Value is {0:F3}", e.NewValue);
        }
    }
}