using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentScore.Startup))]
namespace StudentScore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
