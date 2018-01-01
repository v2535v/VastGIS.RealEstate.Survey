using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Plugins.RealEstate.Helpers
{
    public class FileHelper
    {

        public static bool OpenFile(string title, string filter, int filterIndex, IMainView parent, out string filename)
        {
            filename = null;

            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = false;
                dialog.Filter = filter;
                dialog.FilterIndex = filterIndex;

                if (!string.IsNullOrWhiteSpace(title))
                {
                    dialog.Title = title;
                }
                if (parent == null)
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        filename = dialog.FileName;
                    }
                }
                else if (dialog.ShowDialog(parent as IWin32Window) == DialogResult.OK)
                {
                    filename = dialog.FileName;
                }
            }

            return filename != null;
        }
        public static bool OpenFile(string title,string filter, bool multiSelect, int filterIndex,IMainView parent, out string[] filenames)
        {
            filenames = null;

            using (var dialog = new OpenFileDialog())
            {
                dialog.Multiselect = multiSelect;
                dialog.Filter = filter;
                dialog.FilterIndex = filterIndex;

                if (!string.IsNullOrWhiteSpace(title))
                {
                    dialog.Title = title;
                }
                if (parent == null)
                {
                    if(dialog.ShowDialog() == DialogResult.OK)
                    {
                        filenames = dialog.FileNames;
                    }
                }
                else if (dialog.ShowDialog(parent as IWin32Window) == DialogResult.OK)
                {
                    filenames = dialog.FileNames;
                }
            }

            return filenames != null;
        }

     
    }
}
