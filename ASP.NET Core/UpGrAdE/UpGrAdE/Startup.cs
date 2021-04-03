using UpGrAdE.Models.Interfaces;
using UpGrAdE.Models.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyProject
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);

            //Test
            // services.AddSingleton<IPersonRepository, MockPersonRepository>();
            // services.AddSingleton<ISkillRepository, MockSkillRepository>();


            services.AddSingleton<ICognitiveRepository, CognitiveRepository>();
            services.AddSingleton<IKnowledgeRepository, KnowledgeRepository>();
            services.AddSingleton<IPhysicalRepository, PhysicalRepository>();
            services.AddSingleton<ISkillRepository, SkillRepository>();
            services.AddSingleton<IPersonRepository, PersonRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            //app.UseMvcWithDefaultRoute();

            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=Learning}/{action=Skills}/{id?}");
            //});

            app.UseMvc();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"No page : The application {env.ApplicationName} runs in {env.EnvironmentName} environment !");
            });


        }
    }
}
