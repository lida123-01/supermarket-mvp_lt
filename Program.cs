using supermarket_mvp_lt._Repositories;
using supermarket_mvp_lt.Models;
using supermarket_mvp_lt.Presenters;
using supermarket_mvp_lt.Properties;
using supermarket_mvp_lt.Views;


namespace supermarket_mvp_lt
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
            string sqlConnectionString = Settings.Default.SqlConnection;
            IPayModeView view = new PayModeView();
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
            Application.Run((Form) view);
        }
    }
}