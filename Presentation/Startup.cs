using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Articles.Queries.GetArticleList;
using Application.Interfaces.Persistance;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistance.Articles;
using Persistance.Shared;

namespace Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.Configure<RazorViewEngineOptions>(o => {
                o.ViewLocationFormats.Clear();
                o.ViewLocationFormats.Add("/{1}/Views/{0}" + RazorViewEngine.ViewExtension);
                o.ViewLocationFormats.Add("/Shared/Views/{0}" + RazorViewEngine.ViewExtension);
            });

            services.AddDbContext<DatabaseContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("Jaype"));
            });

            services.AddMvc();

            //IoC
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDatabaseContext, DatabaseContext>();
            services.AddTransient<IArticleRepository, ArticleRepository>();
            services.AddTransient<IGetArticlesListQuery, GetArticlesListQuery>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
