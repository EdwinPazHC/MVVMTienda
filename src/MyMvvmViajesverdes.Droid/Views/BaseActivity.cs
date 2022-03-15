using Android.OS;
using AndroidX.AppCompat.Widget;
using MvvmCross.Platforms.Android.Views;
using MvvmCross.ViewModels;

namespace MyMvvmViajesverdes.Droid.Views
{
    public abstract class BaseActivity<TViewModel> : MvxActivity<TViewModel>
        where TViewModel : class, IMvxViewModel
    {
        protected abstract int ActivityLayoutId { get; }

        protected Toolbar Toolbar { get; private set; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(ActivityLayoutId);

            Toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);

            SetSupportActionBar(Toolbar);
        }
    }
}
