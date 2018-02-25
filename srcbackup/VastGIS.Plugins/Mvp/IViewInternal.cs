// -------------------------------------------------------------------------------------------
// <copyright file="IViewInternal.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;

namespace VastGIS.Plugins.Mvp
{
    public interface IViewInternal
    {
        event Action OkClicked;

        ViewStyle Style { get; }

        bool Visible { get; }

        void BeforeClose();

        void Close();

        void ShowView(IWin32Window parent = null);

        void UpdateView();
    }

    public interface IViewInternal<TModel> : IViewInternal
    {
        TModel Model { get; }

        void InitInternal(TModel model);
    }
}