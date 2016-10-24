using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(incident_forms.Startup))]
namespace incident_forms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
