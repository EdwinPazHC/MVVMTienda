using AndroidX.AppCompat.App;
using AndroidX.DrawerLayout.Widget;

namespace MyMvvmViajesverdes.Droid.Views.Helpers
{
    public interface IDrawerActivity
    {
        DrawerLayout DrawerLayout { get; }

        ActionBar SupportActionBar { get; }

        void HideSoftKeyboard();
    }
}
