namespace AbstractFactory_GUI.shape
{
    public abstract class Shape
    {
        private Color color;

        public abstract void draw(Graphics g);

        public void defineColor(int r, int g, int b)
        {
            this.color = Color.FromArgb(r, g, b);
        }

        public Color getColor()
        {
            return color;
        }

    }
}
