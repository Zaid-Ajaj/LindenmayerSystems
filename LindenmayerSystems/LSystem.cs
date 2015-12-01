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

        // if dict Rules has 'symbol' then give the corresponsing value back, 
        // otherwise, return the 'symbol' unchanged
        string FromRule(string symbol) => Rules.ContainsKey(symbol) ? Rules[symbol] : symbol;

        // apply function 'FromRules' to a list of symbols
        string Translate(string symbols)
        {
            var result = symbols.Select(char.ToString).Select(FromRule);
            return string.Join("", result);
        }

        // generate the nth generation of the system by applying Translate n times;
        public string Generate(int n)
        {
            var result = Start;
            while (n > 0)
            {
                result = Translate(result);
                n--;
            }
            return result;
        }

        public string GenerateSlow(int n) => Extensions.Nest(Translate, Start, n);


    }
}
