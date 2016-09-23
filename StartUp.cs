using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson.Serialization;
using RestService.DAL;
using RestService.Models;

namespace RestService
{
    public class Startup
    {
        private readonly AppSettings _appSettings;

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var configuration = builder.Build();

            this._appSettings = new AppSettings();
            configuration.Bind(this._appSettings);
            
            App_Start.BsonMappings.Map();
        }        

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStatusCodePages();
            app.UseMvcWithDefaultRoute();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddSingleton<AppSettings>(this._appSettings);
            services.AddSingleton<IDocumentContext, DocumentContext>();
            services.AddScoped<IDocumentCollection, DocumentCollection>();
            services.AddScoped<IDocumentService, DocumentService>();
        }
    }
}