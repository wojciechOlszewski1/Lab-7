using lab7.Framework;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab7.Extensions
{
    public static class CustomError
    {
        public static IApplicationBuilder UseError(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware(typeof(Error));
        }
    }
}
