using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace 第七章.Filters
{
    public class SampleActionFilter:IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
             //之前
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            //之后
        }
    }
}
