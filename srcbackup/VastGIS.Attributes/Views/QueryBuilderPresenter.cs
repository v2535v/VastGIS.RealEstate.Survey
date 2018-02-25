﻿// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Attributes.Views.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;
using VastGIS.UI.Helpers;

namespace VastGIS.Attributes.Views
{
    public class QueryBuilderPresenter : BasePresenter<IQueryBuilderView, QueryBuilderModel>
    {
        private readonly IAppContext _context;
        private string _lastQuery = string.Empty;

        public QueryBuilderPresenter(IQueryBuilderView view, IAppContext context)
            : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");
            _context = context;

            view.TestClicked += OnTestClicked;
            view.RunClicked += OnRunClicked;
        }

        public override bool ViewOkClicked()
        {
            if (Model.IsQuery && !_lastQuery.EqualsIgnoreCase(View.Expression))
            {
                // run the query on hitting OK button
                // if the query has not been executed yet
                OnRunClicked();
            }

            Model.Expression = View.Expression;
            return true;
        }

        private void OnRunClicked()
        {
            if (!View.ValidateOnTheFly(false))
            {
                return;
            }

            _lastQuery = View.Expression;

            var results = new List<int>();
            if (!Query(results)) return;

            // Open extra form with selection options:
            var list = new List<SelectionOperation>
                           {
                               SelectionOperation.New,
                               SelectionOperation.Add,
                               SelectionOperation.Exclude,
                               SelectionOperation.Invert,
                           };

            var operation = AppConfig.Instance.QueryBuilderSelectionOperation;
            const string msg = "Please choose selection mode:";

            var selectedColor = Model.Layer.FeatureSet.SelectionColor;
            if (OptionListHelper.Select(list, ref operation, msg, ref selectedColor, View as IWin32Window))
            {
                AppConfig.Instance.QueryBuilderSelectionOperation = operation;
                Model.Layer.UpdateSelection(results, operation, selectedColor);
                _context.Map.Redraw();
            }
        }

        private void OnTestClicked()
        {
            if (!View.ValidateOnTheFly(false))
            {
                return;
            }

            var results = new List<int>();
            if (Query(results))
            {
                View.ValidationResults = "Number of features selected: " + results.Count;
            }
        }

        private bool Query(List<int> results)
        {
            results.Clear();

            var table = Model.Layer.FeatureSet.Table;

            string err;

            if (!table.ParseExpression(View.Expression, out err))
            {
                MessageService.Current.Info("Failed to parse expression.");
                return false;
            }

            int[] arr;

            if (table.Query(View.Expression, out arr, out err))
            {
                results.AddRange(arr);
                return true;
            }

            return true;
        }
    }
}