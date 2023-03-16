using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodManageCodeFirst.Models;
using FoodManageCodeFirst.FoodRepository;

namespace FoodManageCodeFirst
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
            services.AddApiVersioning(x =>
            {
                x.DefaultApiVersion = new ApiVersion(1, 0);
                x.AssumeDefaultVersionWhenUnspecified = true;
                x.ReportApiVersions = true;
                //enabling http header versioning
                // x.ApiVersionReader = new HeaderApiVersionReader("x-api-version");
            });
            services.AddDbContext<FoodManagementContext>(item => item.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services.AddScoped<IRegistration, RegistrationRepo>();
            services.AddScoped<IItem, ItemsRepo>();
            services.AddScoped<ICustomerCart, CustomerCartRepo>();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAngularOrigins",
                    builder =>
                    {
                        builder.WithOrigins(
                            "http://localhost:4200")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors("AllowAngularOrigins");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
