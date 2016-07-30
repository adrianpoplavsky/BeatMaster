using System.Windows.Input;
using Xamarin.Forms;

namespace BeatMaster
{
    public class CategoryPickerMVVM : BaseViewModel
    {
        public ICommand SelectCategory { get; private set; }

        public CategoryPickerMVVM()
        {
            SelectCategory = new Command(main => { Application.Current.MainPage.Navigation.PushAsync(new MainPage()); });
        }
    }
}
