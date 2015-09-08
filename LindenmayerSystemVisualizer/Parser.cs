using LindenmayerSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft;
using System.IO;

namespace LindenmayerSystemVisualizer
{   
    public class Parser
    {
        public static Dictionary<string,LSystem> LoadSystems()
        {
            var dict = new Dictionary<string, LSystem>();
            var jsonData = File.ReadAllText("lsystems.json");
            dynamic systems = JsonConvert.DeserializeObject(jsonData);
            foreach(var sys in systems)
            {
                var lsystem = new LSystem();
                lsystem.Start = sys.Axiom;
                lsystem.AngleDelta = Math.PI * (sys.Angle.Value / 180.0);

                foreach (var variable in sys.Variables)
                    lsystem.Variables.Add(variable.Value);

                foreach(var rule in sys.Rules)
                    lsystem.Rules.Add(rule.From.Value, rule.To.Value);

                dict.Add(sys.Name.Value, lsystem);
            }
            return dict;
        }
    }
}
