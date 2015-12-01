using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LindenmayerSystems;

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
            var ctxMenu = new ContextMenu();
            var menuItem = new MenuItem("Save");
            menuItem.Click += SavePicture;
            ctxMenu.MenuItems.Add(menuItem);
            picLSystem.ContextMenu = ctxMenu;
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

        private void SavePicture(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                var bmp = picLSystem.Image as Bitmap;
                bmp.Save(sfd.FileName + ".png");
            }
        }
    }
}
