using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DNavarreteS6
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Estudiante());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

