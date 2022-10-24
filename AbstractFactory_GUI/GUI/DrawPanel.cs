using AbstractFactory_GUI.shape;

namespace AbstractFactory_GUI.GUI
{
    public class DrawPanel: Panel
    {
        private Shape shape;

        public void DrawShape(Shape shape)
        {
            this.shape = shape;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (shape != null)
            {
                shape.draw(e.Graphics);
            }
        }
    }
}
