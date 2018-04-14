using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(La_Piazzetta.Startup))]
namespace La_Piazzetta
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
