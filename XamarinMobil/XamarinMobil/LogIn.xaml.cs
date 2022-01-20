using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        static List<Proj> projects;
        public LogIn()
        {
            InitializeComponent();
            GetList();
            ProjList.ItemsSource = projects;
        }
        public static void GetList()
        {
            projects = new List<Proj>();
            for (int i = 1; i <= 18; i++)
            {
                projects.Add(new Proj($"Проект {i}"));
            }
        }

        private void ProjList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new Projects((Proj)e.Item));
        }
    }
}