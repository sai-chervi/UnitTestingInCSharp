using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using static UnitTestingCSharp.SingletonClass;

namespace UnitTestProject
{
	[TestClass]
	public class SingletonClassTest
    {
        [TestMethod]
		public void Singleton_Helper_Test()
		{
			//Arrange
			Mock<IIndustryHelper> helper = new Mock<IIndustryHelper>();
			helper.Setup(x => x.Get());

			//Act
			IndustryNew industry = new IndustryNew(helper.Object);
			industry.GetList();

			//Assert
			helper.VerifyAll();

		}
	}
}
