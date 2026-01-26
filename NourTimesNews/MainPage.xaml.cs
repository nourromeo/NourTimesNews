using NourTimesNews.ViewModels;
using NourTimesNews.Models;

namespace NourTimesNews
{
    public partial class MainPage : ContentPage
    {
        private readonly ArticlesViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();

            viewModel = new ArticlesViewModel();
            BindingContext = viewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.GetCommand.ExecuteAsync(null);
        }
    }

}
