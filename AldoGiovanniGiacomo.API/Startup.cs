using AldoGiovanniGiacomo.API.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace AldoGiovanniGiacomo.API
{
    public class Startup
    {
        private string _connectionString;

        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;


        public Startup(ILogger<Startup> logger, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _logger.LogInformation("Startup begins @ {DATE}", DateTime.UtcNow);

            _connectionString = _configuration.GetConnectionString("ConnectionString"); // Change connection string in appsettings if needed
            _logger.LogInformation("Connection string retrieved @ {DATE}", DateTime.UtcNow);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options => {
                options.AddDefaultPolicy(builder => {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddJsonOptions(opt => {
                    opt.JsonSerializerOptions.IgnoreNullValues = true;
                    opt.JsonSerializerOptions.WriteIndented = true;
                });

            services.AddDbContext<AldoGiovanniGiacomoAPIContext>(o => o.UseLazyLoadingProxies().UseSqlServer(_connectionString));
            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "Aldo, Giovanni e Giacomo API";
                    document.Info.Description = "REST API that we don't deserve but we need";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Giuseppe Barbato",
                        Email = string.Empty,
                        Url = "https://giuseppebrb.github.io/"
                    };
                };
            });

            _logger.LogInformation("Added services @ {DATE}", DateTime.UtcNow);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseCors();

            app.UseOpenApi();
            app.UseSwaggerUi3();

            _logger.LogInformation("Configured services @ {DATE}", DateTime.UtcNow);
        }
    }
}
