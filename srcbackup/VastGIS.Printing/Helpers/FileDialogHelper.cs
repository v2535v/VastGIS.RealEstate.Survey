﻿// -------------------------------------------------------------------------------------------
// <copyright file="FileDialogHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Windows.Forms;

namespace VastGIS.Plugins.Printing.Helpers
{
    internal static class FileDialogHelper
    {
        public static string GetBitmapFilename(string elementName, IWin32Window parent)
        {
            var sfd = new SaveFileDialog
                          {
                              FileName = elementName,
                              Filter =
                                  "Portable Network Graphics (*.png)|*.png|Joint Photographic Experts Group (*.jpg)|*.jpg|Microsoft Bitmap (*.bmp)|*.bmp|Graphics Interchange Format (*.gif)|*.gif|Tagged Image File (*.tif)|*.tif",
                              FilterIndex = 1,
                              AddExtension = true
                          };

            if (sfd.ShowDialog(parent) == DialogResult.Cancel)
            {
                return string.Empty;
            }

            return sfd.FileName;
        }
    }
}