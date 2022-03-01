using DFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFConsole.Ideas
{
    public class ReflectionAssn
    {
        public void GetString(string input, object target, string propertyName)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var prop = target.GetType().GetProperty(propertyName);
                prop?.SetValue(target, input);
            }
        }

        public void Main()
        {
            var encounter = new Encounter();
            GetString("test", encounter, nameof(encounter.Name));
        }
    }
}
