using AbstractFactory_GUI.GUI;
using AbstractFactory_GUI.shape;

namespace AbstractFactory_GUI
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
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());

            Window w = new Window();
            ShapeAbstractFactory factory = ShapeFactoryProducer.GetFactory(false);
            Shape shape = factory.NewShape("circle");
            w.DrawShape(shape);

            Application.Run(w);
        }
    }
}