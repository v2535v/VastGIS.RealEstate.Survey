using System.Windows.Forms;

namespace VastGIS.UI.Style
{
    public interface IStyleService
    {
        void ApplyStyle(Form form);
        void ApplyStyle(Control control);
    }
}
