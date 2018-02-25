﻿// -------------------------------------------------------------------------------------------
// <copyright file="PaperSizesCache.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;

namespace VastGIS.Plugins.Printing.Helpers
{
    /// <summary>
    /// Stores the paper sizes for each of the printers. 
    /// </summary>
    /// <remarks>PrinterSettings.PaperSizes executes lengthy enumeration. Caching speed up things.</remarks>
    public static class PaperSizes
    {
        private static readonly Dictionary<string, List<PaperSize>> _printers =
            new Dictionary<string, List<PaperSize>>();

        public static void AddPaperSizes(PrinterSettings settings)
        {
            if (!_printers.ContainsKey(settings.PrinterName))
            {
                var list = settings.PaperSizes.Cast<PaperSize>().ToList();
                _printers.Add(settings.PrinterName, list);
            }
        }

        public static IEnumerable<PaperSize> GetPaperSizes(PrinterSettings settings)
        {
            CheckPaperSizes(settings);

            return _printers[settings.PrinterName];
        }

        public static PaperSize PaperSizeByFormatName(string formatName, PrinterSettings settings)
        {
            CheckPaperSizes(settings);

            var list = _printers[settings.PrinterName];
            var result = list.FirstOrDefault(size => size.PaperName.ToUpper() == formatName.ToUpper());

            return result;
        }

        private static void CheckPaperSizes(PrinterSettings settings)
        {
            if (!_printers.ContainsKey(settings.PrinterName))
            {
                AddPaperSizes(settings);
            }
        }
    }
}