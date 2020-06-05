using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(nguyenchienthang_lab456.Startup))]
namespace nguyenchienthang_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
