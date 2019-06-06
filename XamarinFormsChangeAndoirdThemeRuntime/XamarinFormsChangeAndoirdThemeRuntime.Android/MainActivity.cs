using Android.App;
using Android.Content.PM;
using Android.OS;

namespace XamarinFormsChangeAndoirdThemeRuntime.Droid
{
    [Activity(Label = "XamarinFormsChangeAndoirdThemeRuntime", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

            GlobalVariables.MainThemeResourceID = Resource.Style.MainTheme;
            GlobalVariables.MainTransparentThemeResourceID = Resource.Style.MainTransparentTheme_Base;
            GlobalEvents.OnAndroidThemeChangeNeeded += GlobalEvents_OnAndroidThemeChangeNeeded; ;

            LoadApplication(new App());
        }

        private void GlobalEvents_OnAndroidThemeChangeNeeded(object sender, int themeid)
        {
            RunOnUiThread(() => {
                SetTheme(themeid);
            });
        }
    }
}