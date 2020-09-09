using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamarinUI.ImFeelingLucky.Models;

namespace XamarinUI.ImFeelingLucky
{
    public class ViewModelBase : ModelBase
    {
        public Command CloseModalCommand => new Command(async () =>
        {
            await App.Current.MainPage.Navigation.PopModalAsync();
        });
    }
}
