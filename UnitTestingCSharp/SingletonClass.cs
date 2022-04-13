using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingCSharp
{
    public class SingletonClass
    {
		//example
        public class Industry
        {
            public void GetList()
            {
                IndustryHelper.Instance().Get();
            }
        }
		public sealed class IndustryHelper : IIndustryHelper
		{
			private static IndustryHelper _instance;
			public static IndustryHelper Instance()
			{
				if (_instance == null)
				{
					_instance = new IndustryHelper();
				}
				return _instance;
			}

			public void Get()
			{

			}
		}
		//end

		//modified

		public class IndustryNew
		{
            private IIndustryHelper _industryHelper;

            public IndustryNew() : this(IndustryHelper.Instance())
            {

            }

            public IndustryNew(IIndustryHelper industryHelper)
            {
                this._industryHelper = industryHelper;
            }

            public void GetList()
			{
				_industryHelper.Get();
			}
		}

		public interface IIndustryHelper
        {
			void Get();
        }
	}
}
