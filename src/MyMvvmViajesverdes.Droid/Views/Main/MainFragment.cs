using MvvmCross.Platforms.Android.Presenters.Attributes;
using MyMvvmViajesverdes.Core.ViewModels.Main;

namespace MyMvvmViajesverdes.Droid.Views.Main
{
    [MvxFragmentPresentation(typeof(MainContainerViewModel), Resource.Id.content_frame)]
    public class MainFragment : BaseFragment<MainViewModel>
    {
        protected override int FragmentLayoutId => Resource.Layout.fragment_main;
    }
}
