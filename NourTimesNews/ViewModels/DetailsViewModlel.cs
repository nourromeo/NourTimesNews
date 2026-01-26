using CommunityToolkit.Mvvm.ComponentModel;
using NourTimesNews.Models;

namespace NourTimesNews.ViewModels
{
    [QueryProperty("Article", "Article")]
    public partial class DetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Article article;
    }
}
