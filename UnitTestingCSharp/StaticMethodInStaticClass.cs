using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
    class StaticMethodInStaticClass
    {
		// Code sample original
		public class OldBusinessLayer
		{
			public static void Execute()
			{
				LogHelper.Write();
			}
		}
		public static class LogHelper
		{
			public static void Write()
			{

			}
		}
		//end

		//Modified code to write Unit test
		public class BusinessLayer
		{
			public static void Execute()
			{
				Execute(new LogHelperWrapper());
			}

			public static void Execute(ILogHelperWrapper wrapper)
			{
				wrapper.Write();
			}
		}
		public class LogHelperWrapper : ILogHelperWrapper
		{
			public void Write()
			{
				LogHelper.Write();
			}
		}
		public interface ILogHelperWrapper
		{
			void Write();
		}
	}
}
