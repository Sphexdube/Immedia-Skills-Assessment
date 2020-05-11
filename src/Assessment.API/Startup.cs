using Assessment.DataAccess;
using Assessment.Domain.Interfaces;
using Assessment.Domain.Models;
using Assessment.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Net.Http;

namespace Assessment.API
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();

      services.Configure<DatabaseSettings>(Configuration.GetSection("DatabaseSettings"));
      services.Configure<FoursquareCredentials>(Configuration.GetSection("Foursquare:Credentials"));
      services.Configure<FoursquareConfiguration>(Configuration.GetSection("Foursquare:Configuration"));

      services.TryAddSingleton<DatabaseSettings>(sp => sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);
      services.TryAddSingleton<FoursquareCredentials>(sp => sp.GetRequiredService<IOptions<FoursquareCredentials>>().Value);
      services.TryAddSingleton<FoursquareConfiguration>(sp => sp.GetRequiredService<IOptions<FoursquareConfiguration>>().Value);
      
      services.TryAddSingleton<HttpClient>();
      services.TryAddSingleton<IDataService, DataService>();
      services.TryAddSingleton<ILocationService, LocationService>();
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });

      //Default startup message to indicate api works.
      app.Run(async context =>
      {
        await context.Response.WriteAsync("<h3>ASP.NET Core Web API</h3>");
      });
    }
  }
}
