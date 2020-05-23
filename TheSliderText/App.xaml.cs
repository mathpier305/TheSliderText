using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TheSliderText
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TheSliderPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
