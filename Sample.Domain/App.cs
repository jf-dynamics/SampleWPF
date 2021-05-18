using MvvmCross.ViewModels;
using Sample.Domain.ViewModels;

namespace Sample.Domain
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<DashboardViewModel>();
        }
    }
}
