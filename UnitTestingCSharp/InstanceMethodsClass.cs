using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
	public class InstanceMethodsClass
	{
		public int PublicInstanceMethod_Add(int a, int b)
        {
			return a + b;
        }

		private int PrivateInstanceMethod_Subtract(int a, int b)
        {
			return a - b;
        }
	}
}
