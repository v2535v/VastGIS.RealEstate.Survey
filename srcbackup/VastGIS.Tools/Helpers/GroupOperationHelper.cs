﻿// -------------------------------------------------------------------------------------------
// <copyright file="GroupOperationHelper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Linq;
using System.Text;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Tools.Helpers
{
    /// <summary>
    /// Extension methods for FieldOperationList.
    /// </summary>
    internal static class GroupOperationHelper
    {
        /// <summary>
        /// Validates group operations against specified featureset and displays error message on failure.
        /// </summary>
        public static bool ValidateWithMessage(this FieldOperationList operations, IFeatureSet fs)
        {
            if (!operations.Validate(fs))
            {
                var sb = new StringBuilder("Invalid group operations are found: " + Environment.NewLine);

                foreach (var op in operations.Where(op => !op.OperationIsValid))
                {
                    sb.AppendFormat("{0}: {1}{2}", op.FieldName, op.OperationIsValidReason.EnumToString(), Environment.NewLine);
                }

                MessageService.Current.Warn(sb.ToString());

                return false;
            }

            return true;
        }
    }
}