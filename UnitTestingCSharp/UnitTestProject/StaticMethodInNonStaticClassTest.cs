using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using static UnitTestingCSharp.StaticMethodInNonStaticClass;

namespace UnitTestProject
{
	[TestClass]
	public class StaticMethodInNonStaticClassTest
    {
		[TestMethod]
		public void ProductBL_Wrapper_Test()
		{
			//Arrange
			Mock<IWrapper> wrapper = new Mock<IWrapper>();
			wrapper.Setup(x => x.LogData(It.IsAny<string>()));
			//Act
			new ProductBL(wrapper.Object).LogMessage("Hello");
			//Assert
			wrapper.VerifyAll();
		}
	}
}
