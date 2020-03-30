﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;
using System;

namespace MyBI.WebSite.Middleware
{
    public static class CompressedStaticFileExtensions
    {
        public static IApplicationBuilder UseCompressedStaticFiles(this IApplicationBuilder app)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<CompressedStaticFileMiddleware>();
        }


        public static IApplicationBuilder UseCompressedStaticFiles(this IApplicationBuilder app, StaticFileOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException(nameof(app));
            }

            return app.UseMiddleware<CompressedStaticFileMiddleware>(Options.Create(options));
        }
    }
}
