using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
	public class InstanceMethodsClass
	{
		int sum, diff;
		public int PublicInstanceMethod_Add(int a, int b)
        {
			sum = a + b;
			return sum;
        }

		private int PrivateInstanceMethod_Subtract(int a, int b)
        {
			diff = a - b;
			return diff;
        }
	}
}
