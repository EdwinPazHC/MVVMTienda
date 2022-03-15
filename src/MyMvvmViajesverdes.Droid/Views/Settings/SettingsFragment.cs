using MvvmCross.Platforms.Android.Presenters.Attributes;
using MyMvvmViajesverdes.Core.ViewModels.Main;
using MyMvvmViajesverdes.Core.ViewModels.Settings;

namespace MyMvvmViajesverdes.Droid.Views.Settings
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame, true)]
    public class SettingsFragment : BaseFragment<SettingsViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_settings;
    }
}
