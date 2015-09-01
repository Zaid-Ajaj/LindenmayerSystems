using System;
using System.Windows.Forms;
using static System.Math;

namespace LindenmayerSystems
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            // usage
            var sys = new LSystem() { Start = "F", AngleDelta = PI * (22.0/180.0) };
            sys.Rules.Add("F", "FF-[-F+F+F]+[+F-F-F]");
            var turtle = new TurtleGraphics(sys);
            turtle.Width = 500;
            turtle.Height = 500;
            var bmp = turtle.InterpretBracketed(sys.Generate(4));
            var sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                bmp.Save(sfd.FileName + ".bmp");
        }
    }
}
