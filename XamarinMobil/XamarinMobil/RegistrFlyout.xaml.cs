using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMobil
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistrFlyout : ContentPage
    {
        public ListView ListView;

        public RegistrFlyout()
        {
            InitializeComponent();

            BindingContext = new RegistrFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        class RegistrFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<RegistrFlyoutMenuItem> MenuItems { get; set; }

            public RegistrFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<RegistrFlyoutMenuItem>(new[]
                {
                    new RegistrFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new RegistrFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new RegistrFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new RegistrFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new RegistrFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}