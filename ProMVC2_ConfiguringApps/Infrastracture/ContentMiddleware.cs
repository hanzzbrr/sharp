using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMVC2_ConfiguringApps.Infrastracture
{
    public class ContentMiddleware
    {
        private RequestDelegate nextDelegate;

        public ContentMiddleware(RequestDelegate next) => nextDelegate = next;

        public async Task Invoke(HttpContext httpcontext)
        {
            if(httpcontext.Request.Path.ToString().ToLower() == "/middleware")
            {
                await httpcontext.Response.WriteAsync(
                    "this if from content middleware", Encoding.UTF8);
            }
            else
            {
                await nextDelegate.Invoke(httpcontext);
            }
        }
    }
}
