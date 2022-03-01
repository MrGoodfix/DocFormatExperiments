using DFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFConsole.Ideas
{
    public class ReturnValue
    {
        public string GetString(string input, string output)
        {
            if (!string.IsNullOrEmpty(input))
            {
                return input;
            }
            return output;
        }

        public void Main()
        {
            var encounter = new Encounter();
            encounter.Name = GetString("test", encounter.Name);
        }
    }
}
