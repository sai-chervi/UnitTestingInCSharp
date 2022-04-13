using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using static UnitTestingCSharp.StaticMethodInStaticClass;

namespace UnitTestProject
{
	[TestClass]
	public class StaticMethodInStaticClass
    {
		[TestMethod]
		public void StaticInStatic_Wrapper_Test()
		{
			//Arrange
			Mock<ILogHelperWrapper> wrapper = new Mock<ILogHelperWrapper>();
			wrapper.Setup(x => x.Write());

			//Act
			BusinessLayer.Execute(wrapper.Object);

			//Assert
			wrapper.VerifyAll();

		}
	}
}
