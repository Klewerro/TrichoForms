using MvvmCross.IoC;
using MvvmCross.ViewModels;
using TrichoForms.Core.ViewModels;
using Xamarin.Essentials;

namespace TrichoForms.Core
{
    public class CoreApp : MvxApplication
    {
        private const string FIRST_START_KEY = "first_start";


        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            AppStartRegistration();
        }


        private void AppStartRegistration()
        {
            var isFirstStart = Preferences.ContainsKey(FIRST_START_KEY);

            if (isFirstStart)
            {
                RegisterAppStart<MainViewViewModel>();
            }
            else
            {
                RegisterAppStart<HomeViewModel>();
                Preferences.Set(FIRST_START_KEY, true);
            }
        }

    }
}
