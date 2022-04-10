using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("UnitTestProject")]
namespace UnitTestingCSharp
{
	internal class StaticMethodsClass
	{
		public static int PublicStaticMethod_Multiply(int a, int b)
		{
			return a * b;
		}

		private static int PrivateStaticMethod_Divide(int a, int b)
		{
			return a / b;
		}
	}
}
