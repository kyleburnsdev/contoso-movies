
using ContosoMovies.Catalog.Model;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace ContosoMovies.Catalog
{
    public class GetItem
    {
        private readonly ILogger _logger;
        private readonly MoviesContext _moviesContext;

        public GetItem(ILoggerFactory loggerFactory, MoviesContext moviesContext)
        {
            _logger = loggerFactory.CreateLogger<GetCategories>();
            _moviesContext = moviesContext;
        }

        [Function(nameof(GetItem))]
        public Item Run([HttpTrigger(AuthorizationLevel.Anonymous, "get"
            , Route = "item/{ItemId}")] HttpRequestData req, int ItemId)
        {
            _logger.LogInformation("Retrieving specific item");
            return _moviesContext.Items.Where(i => i.ItemId == ItemId).FirstOrDefault();         
        }
    }
}
