using FactoryMethod_GUI.GUI;
using FactoryMethod_GUI.shape;

namespace FactoryMethod_GUI
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
            

            Window w = new Window();                   
            Shape shape = ShapeFactory.NewShape(1);   
            w.DrawShape(shape);
           
            Application.Run(w);


        }
    }
}