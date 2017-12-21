using System;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Events;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.Concrete
{
    public abstract class BaseCommand : ICommand
    {
        protected string _description;
        protected string _headerName;
        protected Bitmap _icon;
        protected string _key;
        protected PluginIdentity _pluginIdentity;
        protected Keys _shortcutKeys;
        protected string _text;
        protected string _toolStripExName;
        protected string _message;
        protected string _tooltip;
        protected bool _isEnabled;
        protected bool _isChecked;

        protected BaseCommand()
        {
            _isEnabled = true;
            _isChecked = false;
        }
        public string Description
        {
            get { return _description; }
        }

        public string HeaderName
        {
            get { return _headerName; }
        }

        public Bitmap Icon
        {
            get { return _icon; }
        }

        public string Key
        {
            get { return _key; }
        }

        public PluginIdentity PluginIdentity
        {
            get { return _pluginIdentity; }
            set { _pluginIdentity = value; }
        }

        public Keys ShortcutKeys
        {
            get { return _shortcutKeys; }
            set { _shortcutKeys = value; }
        }

        public string Text
        {
            get { return _text; }
        }

        public string ToolStripExName
        {
            get { return _toolStripExName; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string Tooltip
        {
            get { return _tooltip; }
            set { _tooltip = value; }
        }

        public virtual void OnClick()
        {
            
        }

        public virtual void OnCreate(object hook)
        {
           
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
        }

        public bool IsChecked
        {
            get { return _isChecked; }
            set { _isChecked = value; }
        }
    }


    public abstract class BaseTool : BaseCommand, IMapTool
    {
        protected MapCursor _cursor;
        public virtual void OnAfterShapeEdit(IMuteMap map, AfterShapeEditEventArgs e)
        {
            
        }

        public virtual void OnMapCursorChanged(IMuteMap map, EventArgs e)
        {
            
        }

        public virtual void OnMouseDoubleClick(IMuteMap map, EventArgs e)
        {
            
        }

        public virtual void OnMouseDown(IMuteMap map, MouseEventArgs e)
        {
            
        }

        public virtual void OnMouseMove(IMuteMap map, MouseEventArgs e)
        {
            
        }

        public virtual void OnMouseUp(IMuteMap map, MouseEventArgs e)
        {
            
        }

        public virtual void Activiate()
        {
            
        }

        public virtual void Deactiviate()
        {
            
        }

        public MapCursor MapCursor
        {
            get { return _cursor; }
            set { _cursor = value; }
        } 
    }
}