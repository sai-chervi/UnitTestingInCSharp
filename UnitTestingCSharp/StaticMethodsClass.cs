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
		static int product, dividend;
		public static int PublicStaticMethod_Multiply(int a, int b)
		{
			product = a * b;
			return product;
		}

		private static int PrivateStaticMethod_Divide(int a, int b)
		{
			dividend = a / b;
			return dividend;
		}
	}
}
