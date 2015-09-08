using System.Collections.Generic;
using System.Linq;

namespace LindenmayerSystems
{
    // Representation of the Lindenmayer System
    public class LSystem
    {
        public string Start { get; set; } = "";
        public Dictionary<string, string> Rules { get; set; } = new Dictionary<string, string>();
        public double AngleDelta { get; set; } = 0.0;
        public List<string> Variables { get; set; } = new List<string>();


        string FromRule(string symbol) => Rules.ContainsKey(symbol) ? Rules[symbol] : symbol;


        string Translate(string symbols)
        {
            var result = symbols.Select(char.ToString).Select(FromRule);
            return string.Join("", result);
        }

        public string Generate(int n) => Extensions.Nest(Translate, Start, n);
    }
}
