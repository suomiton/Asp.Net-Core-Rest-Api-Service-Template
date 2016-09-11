using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using RestService.DAL;

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
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<AppSettings>(this._appSettings);
            services.AddSingleton<IDocumentContext, DocumentContext>();
            services.AddScoped<IDocumentCollection, DocumentCollection>();
            services.AddScoped<IDocumentService, DocumentService>();
            services.AddMvc();
        }
    }
}