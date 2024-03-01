using Velopack;

namespace PizzaPlace
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            VelopackApp.Build().Run();
            var application = new PizzaPlace.App();
            application.InitializeComponent();
            application.Run();
        }
    }
}