// -------------------------------------------------------------------------------------------
// <copyright file="IEditForm.cs" company="MapWindow OSS Team - www.mapwindow.org">
//  MapWindow OSS Team - 2018
// </copyright>
// -------------------------------------------------------------------------------------------

using System;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public interface IEditForm
    {
        void SetQueryPoint(double dx, double dy);
        bool Visible { get;set; }
        bool IsDisposed { get; }
        void ClearDrawing();
    }

    public interface IEditForm2 : IEditForm
    {
        event EventHandler ShowEvent;
    }
}