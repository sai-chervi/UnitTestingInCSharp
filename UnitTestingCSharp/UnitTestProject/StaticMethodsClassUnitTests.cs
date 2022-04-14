using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitTestingCSharp;

namespace UnitTestProject
{
	[TestClass]
	public class StaticMethodsClassUnitTests
    {
		[TestMethod]
		public void PublicStaticMethod_Multiply_Test()
		{
			//Arrange
			PrivateType obj = new PrivateType(typeof(StaticMethodsClass));

			//Act
			int result = StaticMethodsClass.PublicStaticMethod_Multiply(5, 6);
			int product = (int)obj.GetStaticField("product");

			//Assert
			Assert.AreEqual(30, result);
			Assert.AreEqual(30, product);
		}

		[TestMethod]
		public void PrivateStaticMethod_Divide_Test()
		{
			//Arrange
			PrivateType obj = new PrivateType(typeof(StaticMethodsClass));

			//Act
			object result = obj.InvokeStatic("PrivateStaticMethod_Divide", new Type[] { 6.GetType(), 5.GetType() }, new object[] { 6, 5 });
			int answer = int.Parse(result.ToString());
			int dividend = (int)obj.GetStaticField("dividend");

			//Assert
			Assert.AreEqual(1, dividend);
			Assert.AreEqual(1, answer);
		}
	}
}
