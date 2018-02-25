using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Legend.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.Interfaces
{
    public interface IMainView : IView
    {
        object DockingManager { get; }
        object MenuManager { get; }
        object StatusBar { get; }
        object RibbonControlAdv { get; }
        IMap Map { get; }
        IView View { get; }
        MainViewType ViewType { get; }
        event EventHandler<CancelEventArgs> ViewClosing;
        event EventHandler<RenderedEventArgs> ViewUpdating;
        event Action BeforeShow;
        void Lock();
        void Unlock();
        void DoUpdateView(bool focusMap = true);
    }
}
