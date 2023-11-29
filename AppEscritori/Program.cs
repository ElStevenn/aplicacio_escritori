namespace AppEscritori
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Declaraci�n de la parte de gestionar museo
            GestionarParteMuseo gestor_museo = new GestionarParteMuseo();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}