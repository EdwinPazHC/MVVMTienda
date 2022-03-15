using MvvmCross.IoC;
using MvvmCross.ViewModels;
using MyMvvmViajesverdes.Core.ViewModels.Main;

namespace MyMvvmViajesverdes.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<MainViewModel>();
        }
    }
}
