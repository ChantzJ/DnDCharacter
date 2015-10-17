using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DnDCharacter.Startup))]
namespace DnDCharacter
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
