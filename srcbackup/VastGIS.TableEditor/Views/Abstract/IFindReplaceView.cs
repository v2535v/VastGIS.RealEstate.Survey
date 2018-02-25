using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.TableEditor.Model;

namespace VastGIS.Plugins.TableEditor.Views.Abstract
{
    public interface IFindReplaceView: IView<FindReplaceModel>
    {
        event Action Find;
        event Action Replace;
        event Action ReplaceAll;

        void UpdateSearchInfo();
        void ForceClose();
    }
}
