using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.ImFeelingLucky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SortitionPage : ContentPage
    {
        public SortitionPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //MyParticleCanvas.IsRunning = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            //MyParticleCanvas.IsRunning = false;
        }

        private void Label_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName.Equals(nameof(Label.Text)))
            {
                var c = (Label)sender;

                Task.Run(async () =>
                {
                    c.Opacity = 0;
                    await c.FadeTo(1, 1000);
                });
            }
        }
    }
}