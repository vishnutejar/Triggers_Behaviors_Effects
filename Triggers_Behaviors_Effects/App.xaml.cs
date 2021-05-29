using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Triggers_Behaviors_Effects
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MultiTriggersExample());
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
