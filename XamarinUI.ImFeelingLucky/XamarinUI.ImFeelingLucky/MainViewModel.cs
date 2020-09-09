using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinUI.ImFeelingLucky
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {

        }

        public Command NavigateToSortitionPageCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PushAsync(new SortitionPage(), true);
        });
    }
}
