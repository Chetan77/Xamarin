using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace QualityMeasurement
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double number = Convert.ToDouble(enteredValue.Text);
                if (fromType.SelectedItem.ToString().Equals("mm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("cm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 10;
                            outputValue.Text = $"{changedVal:F3}";
                            return;
                        }
                    }
                }

                if (fromType.SelectedItem.ToString().Equals("mm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("inch"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.0393700787;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("mm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("feet"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.0032808399;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("mm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("meter"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.001;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("cm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("mm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 10;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("inch"))
                {
                    if (ToType.SelectedItem.ToString().Equals("mm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.0393700787;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }

                if (fromType.SelectedItem.ToString().Equals("feet"))
                {
                    if (ToType.SelectedItem.ToString().Equals("mm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.0032808399;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("meter"))
                {
                    if (ToType.SelectedItem.ToString().Equals("mm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.001;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }

                if (fromType.SelectedItem.ToString().Equals("cm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("inch"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.3937007874;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("cm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("feet"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.032808399;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("cm"))
                {
                    if (ToType.SelectedItem.ToString().Equals("meter"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.01;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("inch"))
                {
                    if (ToType.SelectedItem.ToString().Equals("cm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.3937007874;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("feet"))
                {
                    if (ToType.SelectedItem.ToString().Equals("cm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.032808399;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("meter"))
                {
                    if (ToType.SelectedItem.ToString().Equals("cm"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.01;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("inch"))
                {
                    if (ToType.SelectedItem.ToString().Equals("feet"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.0833333333;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("inch"))
                {
                    if (ToType.SelectedItem.ToString().Equals("meter"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.0254;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("feet"))
                {
                    if (ToType.SelectedItem.ToString().Equals("inch"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.0833333333;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("meter"))
                {
                    if (ToType.SelectedItem.ToString().Equals("inch"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu / 0.0254;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("feet"))
                {
                    if (ToType.SelectedItem.ToString().Equals("meter"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.3048;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
                if (fromType.SelectedItem.ToString().Equals("meter"))
                {
                    if (ToType.SelectedItem.ToString().Equals("feet"))
                    {
                        if (double.TryParse(enteredValue.Text, out double valu))
                        {
                            var changedVal = valu * 0.3048;
                            outputValue.Text = $"{changedVal:F3}";
                            return;

                        }
                    }
                }
            }
            catch (FormatException)
            {
                DisplayAlert("warning", "enter the correct value", "ok");
            }
            catch (NullReferenceException)
            {

                DisplayAlert("warning", "please select the type", "ok");
            }
        }
    }
}
