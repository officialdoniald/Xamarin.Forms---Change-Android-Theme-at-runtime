using System;

namespace XamarinFormsChangeAndoirdThemeRuntime
{
    public class GlobalEvents
    {
        public static event EventHandler<int> OnAndroidThemeChangeNeeded;

        public static void OnAndroidThemeChangeNeeded_Event(object sender, int themeid)
        {
            OnAndroidThemeChangeNeeded?.Invoke(sender, themeid);
        }
    }
}