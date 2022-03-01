using DFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFConsole.Ideas
{
    public class DelegateAssn
    {
        public void GetString(string input, Action<string> setOutput)
        {
            if (!string.IsNullOrEmpty(input))
            {
                setOutput(input);
            }
        }

        public void Main()
        {
            var encounter = new Encounter();
            GetString("test", value => encounter.Name = value);
        }
    }
}
