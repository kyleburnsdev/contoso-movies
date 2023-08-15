
using ContosoMovies.Catalog.Model;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ContosoMovies.Catalog
{
    public class GetItemsByCategoryName
    {
        private readonly ILogger _logger;
        private readonly MoviesContext _moviesContext;

        public GetItemsByCategoryName(ILoggerFactory loggerFactory, MoviesContext moviesContext)
        {
            _logger = loggerFactory.CreateLogger<GetCategories>();
            _moviesContext = moviesContext;
        }

        [Function(nameof(GetItemsByCategoryName))]
        public IEnumerable<Item> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get"
            , Route = "category/{CategoryName}")] HttpRequestData req, string CategoryName)
        {
            _logger.LogInformation("Retrieving movies for category");
            return _moviesContext.Set<Item>()
                                 .AsNoTracking()
                                 .Where(i => i.CategoryNavigation.CategoryName == CategoryName)
                                 .ToList();         
        }
    }
}
