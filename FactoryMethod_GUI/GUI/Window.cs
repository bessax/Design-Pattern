using FactoryMethod_GUI.shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod_GUI.GUI
{
    public partial class Window : Form
    {
        private DrawPanel drawPanel;
        public Window()
        {
            InitializeComponent();
            this.drawPanel = new DrawPanel();
            this.Controls.Add(drawPanel);
            this.Update();
        }

        private void Window_Load(object sender, EventArgs e)
        {
           
        }

        public void DrawShape(Shape shape)
        {
            this.drawPanel.DrawShape(shape);
        }
    }
}
