﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VisualRecognition.Domain.DomainServices;
using VisualRecognition.Domain.Entities;
using VisualRecognition.Domain.Interfaces.DomainServices;
using VisualRecognition.Infrastructure.Contexts;

namespace VisualRecognition.API
{
    public class Startup
    {
        private IConfiguration _configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_configuration);
            services.Configure<Token>(_configuration.GetSection("WatsonCredentials"));
            services.AddDbContext<ImageContext>(x => x.UseSqlServer(_configuration["ConnectionString:connection"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IRecognitionService, RecognitionService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("VisualRecognition.API running!");
            });
        }
    }
}
