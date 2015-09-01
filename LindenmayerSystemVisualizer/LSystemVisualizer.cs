using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LindenmayerSystems;
using static System.Math;

namespace LindenmayerSystemVisualizer
{
    public partial class LSystemVisualizer : Form
    {
        // example
        string start = "F";
        string rules = "F,+G-F-G+;G,-F+G+F-";

        TurtleGraphics turtle = new TurtleGraphics();
        LSystem system = new LSystem();

        int generation = 0;
        
        void AddRules(string input, LSystem sys)
        {
            sys.Rules = new Dictionary<string, string>();
            var rules = input.Split(';');
            rules.ForEach(rule => {
                var variables = rule.Split(',');
                sys.Rules.Add(variables[0], variables[1]);
            });
        }

        void Draw()
        {

            system.Start = txtAxiom.Text;
            system.AngleDelta = PI * (double.Parse(txtAngle.Text)/180.0);
            AddRules(txtRules.Text, system);
            turtle.LSystem = system;
            picLSystem.Image = turtle.InterpretBracketed(system.Generate(generation));
            
        }
        public LSystemVisualizer()
        {
            InitializeComponent();



            //var sys = new LSystem() { Start = "F", AngleDelta = PI * (22.0 / 180.0) };
            //sys.Rules.Add("F", "FF-[-F+F+F]+[+F-F-F]");
            //var turtle = new TurtleGraphics(sys);
            //turtle.Width = 500;
            //turtle.Height = 500;
            //turtle.Angle = -PI / 2.0;
            //var bmp = turtle.InterpretBracketed(sys.Generate(4));

            txtAxiom.Text = start;
            txtRules.Text = rules;
            txtAngle.Text = 60 + "";
            btnDraw.Click += (sender, e) => Draw();

            sliderGeneration.ValueChanged += (sender, e) =>
            {
                generation = sliderGeneration.Value;
                label4.Text = $"N = {sliderGeneration.Value}";
                Draw();
            };



        }
    }
}
