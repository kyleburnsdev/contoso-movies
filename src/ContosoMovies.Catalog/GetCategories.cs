
using ContosoMovies.Catalog.Model;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ContosoMovies.Catalog
{
    public class GetCategories
    {
        private readonly ILogger _logger;
        private readonly MoviesContext _moviesContext;

        public GetCategories(ILoggerFactory loggerFactory, MoviesContext moviesContext)
        {
            _logger = loggerFactory.CreateLogger<GetCategories>();
            _moviesContext = moviesContext;
        }

        [Function(nameof(GetCategories))]
        public IEnumerable<Category> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req)
        {
            _logger.LogInformation("Retrieving Categories");
            return _moviesContext.Categories.ToList();            
        }
    }
}
