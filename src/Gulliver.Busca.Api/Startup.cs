using System;
using System.Linq;
using Gulliver.Busca.Api.Configuration;
using Gulliver.Busca.Api.RefitServices;
using Gulliver.Busca.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Refit;

namespace Gulliver.Busca.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AppSettings = new();
        }

        public IConfiguration Configuration { get; }

        private AppSettings AppSettings { get; set; }

        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.GetSection("DefaultConfiguration").Bind(AppSettings);

            services.AddRefitClient<ISerpEngine>(p => new RefitSettings()
            {
                ContentSerializer = new SystemTextJsonContentSerializer(JsonConfiguration.JsonSerializerOptions)
            })
            .ConfigureHttpClient(c =>
                c.BaseAddress = new Uri(
                    AppSettings.Services.First(x =>
                        x.Name.Equals("SerpEngine")).Endpoint));

            services.AddSingleton<AppSettings>(x => AppSettings);
            services.AddSingleton<IBuscaService, BuscaService>();

            services.AddMvc()
            .AddJsonOptions(options => {
                options.JsonSerializerOptions.PropertyNameCaseInsensitive = JsonConfiguration.JsonSerializerOptions.PropertyNameCaseInsensitive;
                options.JsonSerializerOptions.PropertyNamingPolicy = JsonConfiguration.JsonSerializerOptions.PropertyNamingPolicy;
                options.JsonSerializerOptions.IgnoreReadOnlyFields = JsonConfiguration.JsonSerializerOptions.IgnoreReadOnlyFields;
                options.JsonSerializerOptions.Encoder = JsonConfiguration.JsonSerializerOptions.Encoder;
                options.JsonSerializerOptions.WriteIndented = JsonConfiguration.JsonSerializerOptions.WriteIndented;
            });

            services.AddControllers();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Gulliver.Busca.Api", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gulliver.Busca.Api v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
