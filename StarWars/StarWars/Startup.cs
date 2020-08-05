using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarWars.Helpers.Planet;
using StarWars.Helpers.Vehicle;
using StarWars.Interfaces.Planet;
using StarWars.Interfaces.Vehicle;
using StarWars.Helpers.Common;
using StarWars.Interfaces.Common;
using StarWars.Interfaces.People;
using StarWars.Helpers.People;
using StarWar.Helpers.Planet;
using StarWare.Helpers.Vehicle;

namespace StarWars
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

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Register IOCs
            //
            // Common
            services.AddScoped<IRequestHelper, RequestHelper>();
            services.AddScoped<ICommonUrlHelper, CommonUrlHelper>();

            // Planet
            services.AddScoped<IPlanetHelper, PlanetHelper>();
            services.AddScoped<IPlanetRequestHelper, PlanetRequestHelper>();
            services.AddScoped<IPlanetMappingHelper, PlanetMappingHelper>();
            services.AddScoped<IPlanetDecoratorHelper, PlanetDecoratorHelper>();

            // Vehicle
            services.AddScoped<IVehicleHelper, VehicleHelper>();
            services.AddScoped<IVehicleRequestHelper, VehicleRequestHelper>();
            services.AddScoped<IVehicleMappingHelper, VehicleMappingHelper>();
            services.AddScoped<IVehicleDecoratorHelper, VehicleDecoratorHelper>();

            // People
            services.AddScoped<IPeopleHelper, PeopleHelper>();
            services.AddScoped<IPeopleRequestHelper, PeopleRequestHelper>();
            services.AddScoped<IPeopleMappingHelper, PeopleMappingHelper>();
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
                app.UseExceptionHandler("/Shared/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
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
