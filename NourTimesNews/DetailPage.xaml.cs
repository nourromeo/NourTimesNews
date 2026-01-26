using NourTimesNews.ViewModels;

namespace NourTimesNews;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}