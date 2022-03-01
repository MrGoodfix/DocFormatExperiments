using DFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DFConsole.Ideas
{
    public class LinqAssn
    {
        public void GetString<T>(string input, T target, Expression<Func<T, string>> outExpr)
        {
            if (!string.IsNullOrEmpty(input))
            {
                var expr = (MemberExpression)outExpr.Body;
                var prop = (PropertyInfo)expr.Member;
                prop.SetValue(target, input, null);
            }
        }

        public void Main()
        {
            var encounter = new Encounter();
            GetString("test", encounter, x => x.Name);
        }
    }
}
