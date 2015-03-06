using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace AutoCompleteBox
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            if (SimpleIoc.Default.IsRegistered<MainViewModel>() == false)
            {
                SimpleIoc.Default.Register(() => new MainViewModel());
            }
        }

        public MainViewModel MainViewModel
        {
            get { return SimpleIoc.Default.GetInstance<MainViewModel>(); }
        }
    }
}
