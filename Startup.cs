using Data.DataContext;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using VsCodeTesteApi.Repositories;

namespace VsCodeTesteApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<DataContext, DataContext>();
            services.AddTransient<ProdutoRepositorio, ProdutoRepositorio>();
            services.AddTransient<CategoriaRepositorio, CategoriaRepositorio>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            
            app.UseMvc();
        }
    }
}
