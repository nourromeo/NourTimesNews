using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NourTimesNews.Models;
using NourTimesNews.Services;
using System.Collections.ObjectModel;

namespace NourTimesNews.ViewModels
{
    public partial class ArticlesViewModel : BaseViewModel
    {
        private readonly NewsService newsService;
        [ObservableProperty]
        ObservableCollection<Article> articles = new ObservableCollection<Article>();

        public ObservableCollection<string> Categories { get; } =
            new ObservableCollection<string>
            {
                "general",
                "business",
                "technology",
                "sports",
                "entertainment",
                "health",
                "science"
            };

        [ObservableProperty]
        string selectedCategory = "general";


        public ArticlesViewModel()
        {
            this.newsService = new NewsService();

        }

        public ArticlesViewModel(NewsService newsService)
        {
            this.newsService = newsService;
        }

        [RelayCommand]
        async Task Get()
        {
            articles.Clear();

            var list = await newsService.GetTopHeadlinesAsync(selectedCategory);

            foreach (var article in list)
                articles.Add(article);

        }


        [RelayCommand]
        async Task GotoDetail(Article article)
        {
            if (article == null)
                return;
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}",
                true,
                new Dictionary<string, object>
                {
                    { "Article", article }
                });
        }


    }
}
