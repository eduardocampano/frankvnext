
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.DependencyInjection;

namespace Frank.Web
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {
            app.UseServices(services =>
            {
                services.AddMvc();
            });

            app.UseMvc(routes =>
			{
			    routes.MapRoute("ApiRoute", "{controller}/{id?}");
			});

			app.UseWelcomePage();
        }       
    }
}