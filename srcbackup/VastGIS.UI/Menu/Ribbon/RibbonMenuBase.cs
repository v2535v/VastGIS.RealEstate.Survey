using System;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.UI.Menu.Ribbon
{
    //! RibbonMenuBase���嵽Header�����RibbonTabItem
    internal abstract class RibbonMenuBase : IMenuBase
    {
        protected const string MainMenuName = "RibbonMenu";
        protected MenuIndex _menuIndex;

        public abstract string Name { get; set; }

        public abstract IMenuItemCollection Items { get; }

        public abstract bool Visible { get; set; }

        public abstract object Tag { get; set; }

        public string Key
        {
            get { return MainMenuName; }
        }

        public ToolbarDockState DockState
        {
            get { return ToolbarDockState.Top; }
            set { throw new NotSupportedException("Dock state for the main menu can't be changed."); }
        }

        public PluginIdentity PluginIdentity
        {
            get { return PluginIdentity.Default; }
        }

        public abstract bool Enabled { get; set; }

        public virtual void Update()
        {
            // do nothing; no separators are needed here
        }

        public abstract void Refresh();

        protected IDropDownMenuItem GetDropDownItem(string key)
        {
            return FindItem(key, PluginIdentity.Default) as IDropDownMenuItem;
        }

        public IMenuItem FindItem(string key, PluginIdentity identity)
        {
            return _menuIndex.GetItem(identity.GetUniqueKey(key));
        }

        public void RemoveItemsForPlugin(PluginIdentity identity)
        {
            _menuIndex.RemoveItemsForPlugin(identity);

            ItemCollectionBase.RemoveItems(Items, identity);
        }
    }
}