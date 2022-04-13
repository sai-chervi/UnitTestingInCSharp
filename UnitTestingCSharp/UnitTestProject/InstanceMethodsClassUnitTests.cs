using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using UnitTestingCSharp;

namespace UnitTestProject
{
	[TestClass]
	public class InstanceMethodsClassUnitTests
	{
		[TestMethod]
		public void PublicInstanceMethod_Add_Test()
		{
			//Arrange
			InstanceMethodsClass instance = new InstanceMethodsClass();
			PrivateObject obj = new PrivateObject(instance);

			//Act
			int result = instance.PublicInstanceMethod_Add(5, 6);
			int sum = (int)obj.GetFieldOrProperty("sum");

			//Assert
			Assert.AreEqual(11, result);
			Assert.AreEqual(11, sum);
		}

		[TestMethod]
		public void PrivateInstanceMethod_Subtract_Test()
		{
			//Arrange
			InstanceMethodsClass instance = new InstanceMethodsClass();
			PrivateObject obj = new PrivateObject(instance);
			
			//Act
			object result = obj.Invoke("PrivateInstanceMethod_Subtract", new Type[] { 6.GetType(), 5.GetType() }, new object[] { 6, 5 });
			int answer = int.Parse(result.ToString());
			int diff = (int)obj.GetFieldOrProperty("diff");
			
			//Assert
			Assert.AreEqual(1, diff);
			Assert.AreEqual(1, answer);
		}
	}
}
