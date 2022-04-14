using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
namespace UnitTestingCSharp
{
    internal class StaticMethodInNonStaticClass
    {
        // Old code
        public class OldProductBL
        {
            public void LogMessage(string message)
            {
                Logger.Write(message);
            }
        }
        public class Logger
        {
            public static void Write(string message)
            {
                //Write your code here to log data
            }
        }
        //end of old code

        // Refactored code
        public class ProductBL
        {
            readonly IWrapper _wrapper;
            public ProductBL(IWrapper wrapper)
            {
                _wrapper = wrapper;
            }
            public void LogMessage(string message)
            {
                _wrapper.LogData(message);
            }
        }


        public class LogWrapper : IWrapper
        {
            string _message = null;
            public LogWrapper(string message)
            {
                _message = message;
            }
            public void LogData(string message)
            {
                Logger.Write(message);
            }
        }

        public interface IWrapper
        {
            void LogData(string message);
        }
        //end
    }
}
