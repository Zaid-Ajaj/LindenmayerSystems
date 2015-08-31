using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;
using static System.Math;

namespace LindenmayerSystems
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var sys = new LSystem() { Start = "F", AngleDelta = PI / 3.0 };
            sys.Rules.Add("F", "+G-F-G+");
            sys.Rules.Add("G", "-F+G+F-");
            var turtle = new TurtleGraphics(sys);
            turtle.Angle = 0.0;
            var bmp = turtle.Interpret(sys.Generate(1));
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                bmp.Save(sfd.FileName + ".bmp");
        }
    }
}
