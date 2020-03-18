﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;
using Poseidon.API.Extensions;
using Serilog;

namespace Poseidon.API.ActionFilters
{
    public class ActionLogFilter : IAsyncActionFilter
    {
        /// <summary>
        /// On every action invocation, log the user's Id, the controller name,
        /// and the action name.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var userId = context.HttpContext.User.SubjectId();
            
            var actionName = context.ActionDescriptor.DisplayName;
            var split = actionName.Split(' ')[0];
            
            Log.Information($"User: [{userId}] {context.HttpContext.Request.Method} [{split}]");
            
            var result = await next();
        }
    }
}