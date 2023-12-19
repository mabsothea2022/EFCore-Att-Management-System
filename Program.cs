using EFCoreAttMgtSystem.Features;
using EFCoreAttMgtSystem.Entities;
namespace EFCoreAttMgtSystem
{
    internal static class Program
    {
        private static TimeSheet timeSheet;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            TimeSheet AppTimeSheet = new TimeSheet();
            AppTimeSheet.DbContext.Database.EnsureCreated();

            var emp = AppTimeSheet.DbContext.Employees.FirstOrDefault();
            if (emp == null)
            {
                var aEmp = new Employee()
                {
                    FullName = "Admin",
                    Position = "Admin",
                    CardNo = "001",
                    UserAccount = new UserAccount()
                    {
                        Username = "Admin",
                        Password = "123"
                    }
                };
                AppTimeSheet.DbContext.Employees.Add(aEmp); 
                AppTimeSheet.DbContext.SaveChanges();
            }
            Application.Run(new LoginForm(AppTimeSheet));
        }
    }
}