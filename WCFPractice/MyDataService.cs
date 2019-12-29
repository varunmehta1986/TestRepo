using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.Web;

namespace WCFPractice
{
	public class MyDataService 
	{
		public static void Initialize(DataServiceConfiguration config)
		{
			config.SetEntitySetAccessRule("Movies", EntitySetRights.AllRead);
			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
		}
	}
}