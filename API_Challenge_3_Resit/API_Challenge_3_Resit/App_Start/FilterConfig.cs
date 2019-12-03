using System.Web;
using System.Web.Mvc;

namespace API_Challenge_3_Resit
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
