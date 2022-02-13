using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork20
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
            services.AddSpaStaticFiles();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            string path = "records.json";
            string json = "";
            if (!File.Exists(path))
            {
                List<Record> records = new List<Record>();
                for (int i = 0; i < 10; i++)
                {
                    records.Add(
                        new Record(
                            i,
                            $"Фамилия_{i}",
                            $"Имя_{i}",
                            $"Отчество_{i}",
                            $"8999999999{i}",
                            $"Адрес_{i}",
                            $"Описание_{i}"));
                }
                json = JsonConvert.SerializeObject(records);
                File.WriteAllText(path, json);
            }

            app.UseStaticFiles();
            app.UseMvc(
                r =>
                {
                    r.MapRoute(
                                name: "default",
                                template: "{controller=Home}/{action=Index}"
                              );
                });
        }
    }
}
