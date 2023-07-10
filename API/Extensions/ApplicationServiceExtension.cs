using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Extensions;

    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors( this IServiceCollection services)=>

        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
            builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader()
            );
            
        }
        
        );
    }
