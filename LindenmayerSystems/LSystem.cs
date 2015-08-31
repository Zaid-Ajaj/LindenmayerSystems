using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LindenmayerSystems
{
    public class LSystem
    {
        public string Start { get; set; }
        public Dictionary<string, string> Rules { get; set; } = new Dictionary<string, string>();
        public double AngleDelta { get; set; }

        string Translate(string start)
        {
            var result = start.AsEnumerable()
                              .Select(c => c.ToString())
                              .Select(x => Rules.ContainsKey(x) ? Rules[x] : x);
            return string.Join("", result);
        }

        public string Generate(int n) => Extensions.Nest(Translate, Start, n);
    }
}
