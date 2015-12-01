using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Drawing.Drawing2D;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace LindenmayerSystems
{
    public class TurtleGraphics
    {
        public double X { get; set; } = 0.0;
        public double Y { get; set; } = 0.0;
        public double Angle { get; set; } = 0.0;
        public LSystem LSystem { get; set; }
        public int Width { get; set; } = 800;
        public int Height { get; set; } = 800;
        public Color Color { get; set; } = Color.Black;
        public Bitmap Image { get; set; }
        public Stack<State> States { get; set; } = new Stack<State>();

        public TurtleGraphics(LSystem sys)
        {
            LSystem = sys;
            Image = new Bitmap(Width, Height);
        }

        public TurtleGraphics(LSystem sys, int width, int height)
        {
            LSystem = sys;
            Width = width;
            Height = height;
            Image = new Bitmap(Width, Height);
        }

        public TurtleGraphics() { } // no initializer

        public Line Scale(Line input, double xMin, double xMax, double yMin, double yMax)
        {
            var output = new Line();
            var xRange = xMax - xMin;
            var yRange = yMax - yMin;
            output.X1 = ((input.X1 - xMin) / xRange) * Width;
            output.X2 = ((input.X2 - xMin) / xRange) * Width;
            output.Y1 = ((input.Y1 - yMin) / yRange) * Height;
            output.Y2 = ((input.Y2 - yMin) / yRange) * Height;
            return output;
        }

        public Bitmap InterpretBracketed(string generation)
        {
            var lines = new List<Line>();
            var symbols = generation.Select(x => x.ToString());
            foreach (var sym in symbols)
            {
                if (LSystem.Variables.Contains(sym)) // variables cause a line to be drawn
                {
                    var oldX = X;
                    var oldY = Y;
                    X = X + Cos(Angle); // new x-coordinate
                    Y = Y + Sin(Angle); // new y-coordinate
                    lines.Add(new Line { X1 = oldX, Y1 = oldY, X2 = X, Y2 = Y });
                }
                else if (sym == "f") // only change state/coordinates -> no line drawn
                {
                    X = X + Cos(Angle);
                    Y = Y + Sin(Angle);
                }
                else if (sym == "+") // turn right
                {
                    Angle -= LSystem.AngleDelta;
                }
                else if (sym == "-") // turn left
                {
                    Angle += LSystem.AngleDelta;
                }
                else if (sym == "[") // push current state
                {
                    var currentState = new State() { X = X, Y = Y, Angle = Angle };
                    States.Push(currentState);
                }
                else if(sym == "]") // retrieved last pushed state
                {
                    var lastState = States.Pop();
                    X = lastState.X;
                    Y = lastState.Y;
                    Angle = lastState.Angle;
                }

            }
            var bmp = new Bitmap(Width, Height);

            if (lines.Count == 0)
                return bmp;

            // create boundary box
            var xMin = lines.Min(line => line.X1) - 2.0; 
            var xMax = lines.Max(line => line.X2) + 2.0; 
            var yMin = lines.Min(line => line.Y1) - 2.0;
            var yMax = lines.Max(line => line.Y2) + 2.0;

            

            using (var graphics = Graphics.FromImage(bmp))
            {
                var pen = new Pen(new SolidBrush(Color));
                lines.Select(line => Scale(line, xMin, xMax, yMin, yMax))
                     .ForEach(line => graphics.DrawLine(pen, (float)line.X1, (float)line.Y1, (float)line.X2, (float)line.Y2));
            }
            return bmp;
        }
    }
}
