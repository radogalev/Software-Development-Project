using SchoolLab.Data.Context;
using SchoolLab.Data.Helpers;
using SchoolLab.WinFormsUI.Forms;

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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var context = new SchoolLabDbContext())
            {
                DatabaseSeeder.SeedAsync(context).Wait();
            }

            Application.Run(new LoginForm());
        }
    }
}