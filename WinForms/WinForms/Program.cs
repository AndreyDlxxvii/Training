using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;


namespace WinForms
{

    static class Game
    {
        static BufferedGraphicsContext context;
        static public BufferedGraphics buffered;

        static public int Width { get; set; }
        static public int Height { get; set; }

        static Game()
        {

        }

        static public void Init (Form form)
        {
            Graphics gr;
            context = BufferedGraphicsManager.Current;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.Width = 800;
            form.Height = 600;
            form.Show();
            Application.Run(form);

        }
    }
}
