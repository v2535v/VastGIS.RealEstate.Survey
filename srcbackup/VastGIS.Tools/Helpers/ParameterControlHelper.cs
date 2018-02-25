﻿// -------------------------------------------------------------------------------------------
// <copyright file="ParameterControlHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using VastGIS.Tools.Controls.Parameters;

namespace VastGIS.Tools.Helpers
{
    /// <summary>
    /// Extension method to work with parameter controls.
    /// </summary>
    internal static class ParameterControlHelper
    {
        /// <summary>
        /// Sets caption to the control, also removing trailing colon.
        /// </summary>
        public static void SetCaption(this ParameterControlBase ctrl, string caption)
        {
            ctrl.Caption = caption;

            if (ctrl is BooleanParameterControl)
            {
                // do nothing
            }
            else
            {
                if (!ctrl.Caption.Trim().EndsWith(":"))
                {
                    ctrl.Caption += ":";
                }
            }
        }
    }
}