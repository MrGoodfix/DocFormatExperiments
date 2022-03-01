using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DFConsole.Configuration
{
    public class OpenXmlMap<TClass>
    {
        public virtual Type ClassType { get; private set; }
        public List<MemberMap> MemberMaps { get; set; }

        public OpenXmlMap()
        {
            ClassType = typeof(TClass);
            MemberMaps = new List<MemberMap>();
        }

        public virtual void Map<TMember>(Expression<Func<TClass, TMember>> expression,
                                         string name)
        {

        }

        public void Assign(string columnName, Expression<Func<TClass, string>> outExpr)
        {
            var expr = (MemberExpression)outExpr.Body;
            var prop = (PropertyInfo)expr.Member;
            
        }
    }
}
