using Android.OS;
using Android.Views;
using Google.Android.Material.Navigation;
using MvvmCross.Platforms.Android.Presenters.Attributes;
using MyMvvmViajesverdes.Core.ViewModels.Main;
using MyMvvmViajesverdes.Core.ViewModels.Menu;
using MyMvvmViajesverdes.Droid.Views.Helpers;

namespace MyMvvmViajesverdes.Droid.Views.Menu
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.navigation_frame)]
    public class MenuFragment : BaseFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_navigation;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = base.OnCreateView(inflater, container, savedInstanceState);

            NavigationView navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            navigationView.SetNavigationItemSelectedListener(this);

            return view;
        }

        public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
            switch (menuItem.ItemId)
            {
                case Resource.Id.nav_home:
                    ViewModel.ShowHomeCommand.Execute();
                    break;
                case Resource.Id.nav_settings:
                    ViewModel.ShowSettingsCommand.Execute();
                    break;
            }

            (Activity as IDrawerActivity)?.DrawerLayout.CloseDrawers();
            return true;
        }
    }
}
