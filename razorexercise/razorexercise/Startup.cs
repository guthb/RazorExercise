using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(razorexercise.Startup))]
namespace razorexercise
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
