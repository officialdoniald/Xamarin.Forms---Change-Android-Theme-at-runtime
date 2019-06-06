using System;
using Xamarin.Forms;

namespace XamarinFormsChangeAndoirdThemeRuntime
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainThemeButton_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() => 
            {
                GlobalEvents.OnAndroidThemeChangeNeeded_Event(null, GlobalVariables.MainThemeResourceID);
            });
        }

        private void MainTransparentButton_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                GlobalEvents.OnAndroidThemeChangeNeeded_Event(null, GlobalVariables.MainTransparentThemeResourceID);
            });
        }
    }
}