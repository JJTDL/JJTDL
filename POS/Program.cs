namespace POS
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
<<<<<<< HEAD
            Application.Run(new frmMain());
=======
            Application.Run(new FrontPanel());
>>>>>>> f538acf27028ff1de36334b1b0f5032eea349ade
        }
    }
}