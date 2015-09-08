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
        Dictionary<string, LSystem> systems = new Dictionary<string, LSystem>();
        int generation = 0;


        void Draw()
        {
            var system = systems[cboxSystems.SelectedItem.ToString()];
            var turtle = new TurtleGraphics(system);
            picLSystem.Image = turtle.InterpretBracketed(turtle.LSystem.Generate(generation));
            
        }
        public LSystemVisualizer()
        {
            InitializeComponent();
            systems = Parser.LoadSystems();
            systems.ForEach(sys => cboxSystems.Items.Add(sys.Key));
            cboxSystems.SelectedIndex = 0;

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
