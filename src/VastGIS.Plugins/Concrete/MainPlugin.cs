using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Concrete
{
    /// <summary>
    /// A consumer of plugin events for the main application. Isn't added to the list of plugins.
    /// </summary>
    public class MainPlugin: BasePlugin
    {
        public MainPlugin()
        {
            Identity = PluginIdentity.Default;
        }

        public override void Initialize(IAppContext context)
        {
            
        }

        public override void Terminate()
        {
            
        }

        protected override void RegisterServices(IApplicationContainer container)
        {

        }
    }
}
