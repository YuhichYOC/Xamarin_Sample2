using Prism.Commands;
using Prism.Navigation;
using System.Windows.Input;

namespace BlankApp3.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public ICommand MainPageButtonCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            MainPageButtonCommand = new DelegateCommand(GoToPage1);
        }

        private void GoToPage1()
        {
            NavigationService.NavigateAsync("Page1");
        }
    }
}