using System.Windows.Forms;

namespace VastGIS.QuickDB.Interface
{
    public interface IAppView
    {
        bool ShowChildView(Form form, bool modal = true);
        bool ShowChildView(Form form, IWin32Window parent, bool modal = true);
        void Update(bool focusMap = true);
        IWin32Window MainForm { get; }
        void Lock();
        void Unlock();
    }
}