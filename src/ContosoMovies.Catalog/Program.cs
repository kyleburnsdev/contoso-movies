using ContosoMovies.Catalog.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;


var config = new ConfigurationBuilder()
                .AddJsonFile("settings.json", true)
                .AddJsonFile("local.settings.json", true)
                .AddEnvironmentVariables()
                .Build();

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    {
        s.AddDbContext<MoviesContext>(options =>
            options.UseSqlServer(config.GetConnectionString("Movies")) );
            //options.UseSqlServer(Configuration.GetConnectionString("Movies")));
    })
    .Build();

host.Run();
