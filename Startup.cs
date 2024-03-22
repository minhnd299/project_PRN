using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QL_BanHang.Interfaces;
using QL_BanHang.Models;
using QL_BanHang.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHang
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
            services.AddDbContext<QL_BanHangTuiXachContext>();

            services.AddControllersWithViews().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore); 

            services.AddScoped<ISanPhamService, SanPhamService>();
            services.AddScoped<IDonHangService, DonHangService>();
            services.AddScoped<IKhachHangService, KhachHangService>();
            services.AddScoped<QL_BanHang.Areas.Admin.Interfaces.IKhachHangService, QL_BanHang.Areas.Admin.Services.KhachHangService>();
            services.AddScoped<INhanVienService, NhanVienService>();
            services.AddScoped<QL_BanHang.Areas.Admin.Interfaces.IDonHangService, QL_BanHang.Areas.Admin.Services.DonHangService>();

            services.AddScoped<IGioHangService, GioHangService>();
            services.AddSession(options =>
            {
                //options.IdleTimeout = TimeSpan.FromSeconds(3000);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;

            });
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseSession();
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                     "Admin",
                     "Admin",
                     "Admin/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
