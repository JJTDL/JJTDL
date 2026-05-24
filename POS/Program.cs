namespace POS
{
    internal static class Program
    {
        // Shared ApplicationContext used to manage the application's lifetime.
        public static ApplicationContext AppContext { get; private set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Create a single ApplicationContext and set the initial main form.
            AppContext = new ApplicationContext();
            var mainForm = new frmMain();
            AppContext.MainForm = mainForm;
            mainForm.Show();

            Application.Run(AppContext);
        }
        public static void SwitchTo(Form nextForm, Form currentForm)
        {
            if (nextForm == null) 
                throw new ArgumentNullException(nameof(nextForm));
            if (currentForm == null) 
                throw new ArgumentNullException(nameof(currentForm));

            // Show the next form and make it the context's MainForm so the message loop continues.
            nextForm.Show();

            if (AppContext != null)
            {
                AppContext.MainForm = nextForm;
            }

            // Close current form; if no forms remain, the AppContext.MainForm closure will end the message loop.
            currentForm.Close();
        }
    }
}