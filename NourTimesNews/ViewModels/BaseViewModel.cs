using CommunityToolkit.Mvvm.ComponentModel;


namespace NourTimesNews.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? title;


    }

}
