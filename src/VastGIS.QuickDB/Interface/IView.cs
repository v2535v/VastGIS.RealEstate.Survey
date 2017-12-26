using System;
using System.ComponentModel;
using System.Windows.Forms;
using VastGIS.QuickDB.Events;

namespace VastGIS.QuickDB.Interface
{
    public interface IView : IViewInternal
    {
        ButtonBase OkButton { get; }

        void StartWait();

        void StopWait();

        Form AsForm { get; }
    }

    public interface IView<TModel> : IView, IViewInternal<TModel>
    {
        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        void Initialize();
    }

    public interface IMainView : IView
    {
       
        object ContextPanel { get; }

        object LeftTreeControll { get; }

        event EventHandler<CancelEventArgs> ViewClosing;
        event EventHandler<RenderedEventArgs> ViewUpdating;
        event Action BeforeShow;
        void Lock();
        void Unlock();
        void DoUpdateView(bool focusData = true);
    }
}