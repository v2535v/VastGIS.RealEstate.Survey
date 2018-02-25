﻿// -------------------------------------------------------------------------------------------
// <copyright file="IAttributeField.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.ComponentModel;
using VastGIS.Api.Enums;

namespace VastGIS.Api.Interfaces
{
    public interface IAttributeField : IComWrapper
    {
        [Browsable(false)]
        string Abbreviation { get; }

        string Alias { get; set; }

        [Browsable(false)]
        string DisplayName { get; }

        IAttributeField Clone();

        [Browsable(false)]
        int Index { get; }

        string Expression { get; set; }

        bool Joined { get; }

        string Name { get; set; }

        int Precision { get; }

        AttributeType Type { get; }

        bool Visible { get; set; }

        int Width { get; }

        bool Modified { get; set; }
    }
}