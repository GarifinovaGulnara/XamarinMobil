using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinMobil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Reg_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogUp());
        }

        private void LogIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LogIn());
        }
    }
}
