using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineShopMVC.Data;

namespace OnlineShopMVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();
            builder.Services.AddDbContext<ProductDbContext>(options =>
            {
                options.UseNpgsql(builder.Configuration.GetConnectionString("DbConnection"));
            });

            builder.Services.AddAuthentication().AddGoogle(options =>
            {
                options.ClientId = builder.Configuration["client_id"];
                options.ClientSecret = builder.Configuration["client_secret"];
            }).AddFacebook(opt =>
            {
                opt.AppId = "1587416215081038";
                opt.AppSecret = "91457c8ca41e61cf450ed08f71f85a3b";
            }).AddGitHub(github =>
            {
                github.ClientId = "ee3f875b6ff4db104ecb";
                github.ClientSecret = "b108dfe4a3d55f7af730b2bc81397981996862ea";
                github.CallbackPath = "/github-oauth";
            }
            );

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ProductDbContext>();
            //builder.Services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ProductDbContext>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Shopping}/{action=Index}");
            app.MapRazorPages();

            app.Run();
        }
    }
}