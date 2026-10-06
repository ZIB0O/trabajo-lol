namespace trabajo_de_profe_jamil_xd
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Cambia Form1() por TIENDADB()
            Application.Run(new TIENDADB());
        }
    }
}