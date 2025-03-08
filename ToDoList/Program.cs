namespace ToDoList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ConnScript.SetConn();           
            await Task.Run(() => DataBaseCreation.DeployDatabase());
            ApplicationConfiguration.Initialize();
            Application.Run(new Register());
        }
    }
}