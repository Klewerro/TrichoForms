using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TrichoForms.Core.ViewModels;

namespace TrichoForms.Core
{
    public class CoreApp : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<HomeViewModel>();
        }

    }
}
