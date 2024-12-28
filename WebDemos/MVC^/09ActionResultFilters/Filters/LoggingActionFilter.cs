using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace _09ActionResultFilters.Filters
{
    public class LoggingActionFilter : IActionFilter
    {

        private Stopwatch _stopwatch;

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _stopwatch = Stopwatch.StartNew();
            if(context.Controller is Controller controller)
            {
                controller.ViewData["OnActionExecuting"] = "Action Execution Started";
            }
        }


        public void OnActionExecuted(ActionExecutedContext context)
        {
            _stopwatch.Stop();
            var time = _stopwatch.ElapsedTicks;
            if (context.Controller is Controller controller)
            {
                controller.ViewData["ElapsedTicks"] = $"Time Taken : {time} ticks.";
                controller.ViewData["OnActionExecuted"] = "Action Execution Stopped.";
            } 
        }

        
    }
}
