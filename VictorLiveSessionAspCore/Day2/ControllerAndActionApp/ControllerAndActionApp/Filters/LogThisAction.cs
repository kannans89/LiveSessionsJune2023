

using Microsoft.AspNetCore.Mvc.Filters;

namespace ControllerAndActionApp.Filters
{
	public class LogThisAction:ActionFilterAttribute
	{

		string controllerName = "";
		string actionName = "";
		public override void OnActionExecuting(ActionExecutingContext context)
		{
            controllerName = (string) context.RouteData.Values["controller"];
            actionName = (string)context.RouteData.Values["action"];
            Console.WriteLine($"Before execution ,ctorller is {controllerName} ,actions is{actionName} @ {getTime()}");

		}

		public override void OnActionExecuted(ActionExecutedContext context)
		{
            Console.WriteLine($"After execution ,ctorller is {controllerName} ,actions is{actionName} @ {getTime()}");

        }

		private string getTime() {
			return DateTime.Now.ToLongTimeString();
		}

	}
}
