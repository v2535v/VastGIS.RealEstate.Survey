// -------------------------------------------------------------------------------------------
// <copyright file="UpdateMeasurementsPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using VastGIS.Api.Concrete;
using VastGIS.Api.Enums;
using VastGIS.Api.Helpers;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Helpers;
using VastGIS.Plugins.Helpers;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Helpers;
using VastGIS.Plugins.TableEditor.Model;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.Shared;

namespace VastGIS.Plugins.TableEditor.Views
{
    public class UpdateMeasurementsPresenter : BasePresenter<IUpdateMeasurementsView, IFeatureSet>
    {
        private readonly IAppContext _context;
        private MeasurementInfo _areaInfo;
        private MeasurementInfo _lengthInfo;

        public UpdateMeasurementsPresenter(IUpdateMeasurementsView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;
        }

        public override bool ViewOkClicked()
        {
            _areaInfo = View.AreaInfo;
            _lengthInfo = View.LengthInfo;

            if (!Validate())
            {
                return false;
            }

            if (!CreateField(_lengthInfo))
            {
                return false;
            }

            if (!CreateField(_areaInfo))
            {
                return false;
            }

            Calculate();

            return true;
        }

        private void Calculate()
        {
            var map = _context.Map;
            var table = Model.Table;

            const string msg = "Updating measurements";
            GlobalListeners.ReportProgress(string.Empty, 0, msg);
            int featureCount = Model.Features.Count;

            foreach (var ft in Model.Features)
            {
                GlobalListeners.ReportProgress(string.Empty, Convert.ToInt32((ft.Index + 1) * 100.0 / featureCount), msg);

                var g = ft.Geometry;

                if (_lengthInfo.Active)
                {
                    double length = map.GeodesicLength(g);

                    length = UnitConversionHelper.Convert(LengthUnits.Meters, View.LengthUnits, length);

                    table.EditCellValue(_lengthInfo.FieldIndex, ft.Index, length);
                }

                if (_areaInfo.Active)
                {
                    double area = map.GeodesicArea(g);

                    area = UnitConversionHelper.Convert(AreaUnits.SquareMeters, View.AreaUnits, area);

                    table.EditCellValue(_areaInfo.FieldIndex, ft.Index, area);
                }
            }

            GlobalListeners.ClearProgress();
        }

        private bool CreateField(MeasurementInfo info)
        {
            if (info.Type == UpdateMeasurementType.NewField)
            {
                info.FieldIndex = Model.Table.Fields.Add(info.Name, AttributeType.Double, info.Precision, info.Width);
                if (info.FieldIndex == -1)
                {
                    MessageService.Current.Info("Failed to create field.");
                    return false;
                }
            }

            return true;
        }

        private bool TryOverwriteField(MeasurementInfo item)
        {
            var fields = Model.Table.Fields;

            if (Model.Table.Fields.Any(f => f.Name.ContainsIgnoreCase(item.Name)))
            {
                if (
                    !MessageService.Current.Ask(
                        "Field name already exist: " + item.Name + Environment.NewLine + "Do you want to override it?"))
                {
                    return false;
                }

                int index = fields.IndexByName(item.Name);
                if (!fields.Remove(index))
                {
                    MessageService.Current.Info("Failed to remove field: " + item.Name);
                }
            }

            return true;
        }

        private bool Validate()
        {
            if (_areaInfo.Type == UpdateMeasurementType.Ignore && _lengthInfo.Type == UpdateMeasurementType.Ignore)
            {
                MessageService.Current.Info("Nothing to calculate. Please select lenght, area or both of them.");
                return false;
            }

            var list = new List<MeasurementInfo> { _lengthInfo, _areaInfo };

            foreach (var item in list)
            {
                switch (item.Type)
                {
                    case UpdateMeasurementType.Ignore:
                        continue;
                    case UpdateMeasurementType.ExistingField:
                        if (item.FieldIndex == -1)
                        {
                            MessageService.Current.Info(
                                "There is no suitable field in the table to write " + item.DefaultName + "." +
                                 Environment.NewLine + "Please choose to create a new field.");
                            return false;
                        }
                        break;
                    case UpdateMeasurementType.NewField:
                        {
                            string err;
                            if (!Model.Table.ValidateFieldNameSlack(item.Name, out err))
                            {
                                MessageService.Current.Info(err);
                                return false;
                            }

                            if (!TryOverwriteField(item))
                            {
                                return false;
                            }
                        }
                        break;
                }
            }

            return true;
        }
    }
}