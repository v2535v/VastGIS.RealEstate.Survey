using VastGIS.QuickDB.Interface;

namespace VastGIS.QuickDB.Views
{
    public static class AppViewFactory
    {
        public static IAppView Instance { get; internal set; }
    }
}