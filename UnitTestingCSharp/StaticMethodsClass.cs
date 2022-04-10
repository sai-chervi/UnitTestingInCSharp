using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
	class StaticMethodsClass
	{
		public int PublicStaticMethod_Multiply(int a, int b)
		{
			return a * b;
		}

		private int PrivateStaticMethod_Divide(int a, int b)
		{
			return a / b;
		}
	}
}
