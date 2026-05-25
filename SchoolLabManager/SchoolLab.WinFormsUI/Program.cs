using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolLab.Data.Context;
using SchoolLab.Data.Repositories.Implementations;
using SchoolLab.Data.Repositories.Interfaces;
using SchoolLab.Services.Implementations;
using SchoolLab.Services.Interfaces;
using SchoolLab.WinFormsUI.Forms;
using SchoolLab.WinFormsUI.Helpers;

namespace SchoolLab.WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();


            services.AddDbContext<SchoolLabDbContext>(options =>
                options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=SchoolLabDB;"));

            services.AddScoped<IAssetRepository, AssetRepository>();
            services.AddScoped<ILoanRepository, LoanRepository>();
            services.AddScoped<IDamageReportRepository, DamageReportRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IAssetService, AssetService>();
            services.AddScoped<ILoanService, LoanService>();
            services.AddScoped<IReportService, ReportService>();
            services.AddScoped<IAuthService, AuthService>();

            services.AddTransient<LoginForm>();
            services.AddTransient<MainDashboard>();

            var provider = services.BuildServiceProvider();

            // Seed (sync wrapper — see Step 3 below)
            using (var scope = provider.CreateScope())
            {
                var ctx = scope.ServiceProvider.GetRequiredService<SchoolLabDbContext>();
                DatabaseSeeder.Seed(ctx); // sync version
            }

            Application.Run(provider.GetRequiredService<LoginForm>());
        }
    }
}