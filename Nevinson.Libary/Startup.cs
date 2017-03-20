using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nevinson.Libary.Data;
using Nevinson.Libary.Service;

namespace Nevinson.Libary
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Add framework services.
            services.AddScoped<ILibraryCard, LibraryCardService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<ILibraryBranch, LibraryBranchService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<IPatron, PatronService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<ICheckout, CheckoutService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<ILibraryAsset, LibraryAssetService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<IBook, BookService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<IVideo, VideoService>(); // so that Bookservice is injected into controllers and other components that request IBook
            services.AddScoped<IStatus, StatusService>(); // so that Bookservice is injected into controllers and other components that request IBook

            // configure ef and dbcontext.
            // ef can now work with other databases, including non-relational
            services.AddDbContext<LibraryDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("LibraryConnection")));


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
