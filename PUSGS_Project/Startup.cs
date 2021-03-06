using DataAcesss.Data;
using DataAcesss.Repos;
using DataAcesss.Repos.Contracts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PUSGS_Project.Mapper;
using ServiceLayer;
using ServiceLayer.Contracts;
using ServiceLayer.Services;
using ServiceLayer.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PUSGS_Project
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
            services.AddDbContext<PUSGS_ProjectContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("PUSGS_Project"));
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Data Access Layer
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISignUpRequestRepository, SignUpRequestRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductOrderRepository, ProductOrderRepository>();

            // Service Layer
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISignUpRequestService, SignUpRequestService>();
            services.AddTransient<IEmailService, EmailService>();
            services.AddTransient<IProductOrderService, ProductOrderService>();

            services.Configure<MailSettings>(Configuration.GetSection("MailSettings"));

            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<PUSGS_ProjectContext>();

            services.ConfigureApplicationCookie(options => {
                options.AccessDeniedPath = new PathString("/Home/AccessDenied");
            });

            services.AddAuthentication().AddGoogle(options => { 
                options.ClientId = "617568169380-rqm60eo3pj4fe0p056t9udmlcmgae1gf.apps.googleusercontent.com";
                options.ClientSecret = "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";
            });

            services.AddAutoMapper(x => x.AddProfile<AutoMapping>(), typeof(Startup));

            services.AddControllersWithViews().AddRazorRuntimeCompilation();

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse = context =>
                {
                    context.Context.Response.Headers.Add("Cache-Control", "no-cache, no-store");
                    context.Context.Response.Headers.Add("Expires", "-1");
                }
            });
        }
    }
}
