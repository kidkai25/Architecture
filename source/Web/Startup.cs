using DotNetCore.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Architecture.Web
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
            application.UseCorsAllowAny();
            application.UseHttps();
            application.UseRouting();
            application.UseStaticFiles();
            application.UseResponseCompression();
            application.UseResponseCaching();
            application.UseAuthentication();
            application.UseAuthorization();
            application.UseEndpoints();
            application.UseSpa();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddSecurity();
            services.AddResponseCompression();
            services.AddResponseCaching();
            services.AddControllersDefault();
            services.AddSpa();
            services.AddContext();
            services.AddServices();
        }
    }
}
