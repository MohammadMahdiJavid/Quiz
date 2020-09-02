using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using UserApi.Repositories;
using UserApi;

namespace Server_api
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
            /* UPLOAD-CORS */
            services.AddCors(options => 
            {
                options.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            /* UPLOAD-CORS */


            services.AddControllers();
            services.AddEntityFrameworkSqlite().AddDbContext<MyDbContext>();
            services.AddTransient<UserRepository>();
            services.AddTransient<CourseRepository>();
            services.AddTransient<QuizzRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            /* UPLOAD */
            app.UseStaticFiles();
            /* UPLOAD */
            app.UseAuthorization();

            /* CORS-POLICY */
            app.UseCors("CorsPolicy");
            /* CORS-POLICY */

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
