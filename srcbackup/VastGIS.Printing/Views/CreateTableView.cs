﻿// -------------------------------------------------------------------------------------------
// <copyright file="CreateTableView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Plugins.Printing.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.Printing.Views
{
    internal partial class CreateTableView : CreateTableViewBase, ICreateTableView
    {
        public CreateTableView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            udColumnCount.Value = Model.ColumnCount;
            udRowCount.Value = Model.RowCount;
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public int RowCount
        {
            get { return Convert.ToInt32(udRowCount.Value); }
        }

        public int ColumnCount
        {
            get { return Convert.ToInt32(udColumnCount.Value); }
        }
    }

    internal class CreateTableViewBase : MapWindowView<CreateTableModel>
    {
    }
}