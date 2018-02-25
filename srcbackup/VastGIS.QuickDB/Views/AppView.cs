using System;
using System.Windows.Forms;
using VastGIS.QuickDB.Concrete;
using VastGIS.QuickDB.Interface;

namespace VastGIS.QuickDB.Views
{
    public class AppView : IAppView
    {
        private readonly IMainView _parent;

        public AppView(IMainView parent)
        {
            if (parent == null) throw new ArgumentNullException("parent");
        
            _parent = parent;
          
            AppViewFactory.Instance = this;
        }

        public bool ShowChildView(Form form, bool modal = true)
        {
            return ShowChildView(form, null, modal);
        }

        public bool ShowChildView(Form form, IWin32Window parent, bool modal = true)
        {
            if (form == null) throw new ArgumentNullException("parent");

       

            if (form is IViewInternal)
            {
                var view = form as IViewInternal;
                var style = view.Style;

                if (style != null)
                {
                    ApplyStyle(form,style);
                    modal = style.Modal;
                }
            }

            if (parent == null)
            {
                parent = _parent as IWin32Window;
            }
            if (modal)
            {
                return form.ShowDialog(parent) == DialogResult.OK;
            }

            form.Show(parent);
            return true;
        }

        private void ApplyStyle(Form form, ViewStyle style)
        {
            form.MaximizeBox = style.Sizable;
            form.MinimizeBox = style.Sizable;
            form.FormBorderStyle = style.Sizable ? FormBorderStyle.Sizable : FormBorderStyle.FixedSingle;

            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowInTaskbar = false;
        }

        public void Lock()
        {
            _parent.Lock();
        }

        public void Unlock()
        {
            _parent.Unlock();
        }

        public void Update(bool focusMap = true)
        {
            _parent.DoUpdateView(focusMap);
        }

        public IWin32Window MainForm
        {
            get { return _parent as IWin32Window; }
        }
    }
}