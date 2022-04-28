using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using ECommerce_MVC_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using ECommerce_MVC_Project.DB_Data;




namespace ECommerce_MVC_Project
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

            services.AddControllersWithViews();
            //step 5 
            //restiering services
            //services.AddSingleton<IData, Data>();
            //services.AddScoped<IData, DBData>();
            //services.AddDbContext<EmployeeContext>(options => options.UseSqlite("Data Source=Employees.db"));
            //services.AddDbContext<ProductContext>(options => options.UseSqlServer("Server=Desktop-TN2F3BI;Database=GloboShoes;Trusted_Connection=True;MultipleActiveResultSets=True"));

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddIdentity<Customer, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;

            }).AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddSession();

            //services.AddDbContext<CustomerContext>(options => options.UseSqlServer("Server=Desktop-TN2F3BI;Database=Customers;Trusted_Connection=True;MultipleActiveResultSets=True"

            //    ));



        }
        static async Task CreateRoles(RoleManager<IdentityRole> roleManager)
        {
            string[] rolenames = { "Admin", "Customer" };
            foreach (var rolename in rolenames)
            {
                bool roleExists = await roleManager.RoleExistsAsync(rolename);
                if (!roleExists)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = rolename;
                    IdentityResult result = await roleManager.CreateAsync(role);
                }
            }
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, RoleManager<IdentityRole> roleManager)
        {
            //productContext.Database.EnsureCreated();
            //userContext.Database.EnsureCreated();
            //userContext.Dispose();
            // create 2 roles
            //     CreateRoles(roleManager);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                
            }
            else if (env.IsProduction())
            {
                app.UseExceptionHandler("/Error.html");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
