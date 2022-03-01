using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DFConsole.Configuration
{
    public class MemberMap
    {
        public virtual MemberInfo Member { get; private set; }
		//public virtual Type Type
		//{
		//	get
		//	{
		//		return Member;
		//	}
		//}


        public MemberMap(MemberInfo member)
        {
			Member = member;
        }
	}
}
