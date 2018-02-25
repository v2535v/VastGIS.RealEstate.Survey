﻿// -------------------------------------------------------------------------------------------
// <copyright file="QueryBuilderView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Helpers;
using VastGIS.Attributes.Model;
using VastGIS.Attributes.Views.Abstract;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Services;
using VastGIS.UI.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace VastGIS.Attributes.Views
{
    public partial class QueryBuilderView : QueryBuilderViewBase, IQueryBuilderView
    {
        private IAttributeTable _table;

        public QueryBuilderView()
        {
            InitializeComponent();

            valueCountGrid1.TableControlCellDoubleClick += OnValueDoubleClick;

            richTextBox1.TextChanged += (s, e) => ValidateOnTheFly(true);

            btnTest.Click += (s, e) => Invoke(TestClicked);
            btnRun.Click += (s, e) => Invoke(RunClicked);

            chkShowValues.Checked = AppConfig.Instance.QueryBuilderShowValue;

            FormClosing += (s, e) => AppConfig.Instance.QueryBuilderShowValue = chkShowValues.Checked;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.R):
                    Invoke(RunClicked);
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private int FieldIndex
        {
            get
            {
                var fld = fieldTypeGrid1.Adapter.SelectedItem;
                return fld != null ? fld.Index : -1;
            }
        }

        public event Action TestClicked;

        public event Action RunClicked;

        public string Expression
        {
            get { return richTextBox1.Text; }
        }

        public string ValidationResults
        {
            get { return lblValidation.Text; }
            set { lblValidation.Text = value; }
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            _table = Model.Layer.FeatureSet.Table;

            lblSelect.Text = string.Format("SELECT * FROM [{0}] WHERE ", Model.Layer.Name);

            InitFieldGrid();

            InitTextBox();

            btnRun.Enabled = Model.IsQuery;            

            ValidateOnTheFly(true);
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public bool ValidateOnTheFly(bool silent)
        {
            if (string.IsNullOrWhiteSpace(Expression))
            {
                lblValidation.Text = "Expression is empty";
                lblValidation.ForeColor = Color.Black;
                lblValidation.Font = new Font(lblValidation.Font, FontStyle.Bold);
            }
            else
            {
                string errorMsg;
                if (_table.TestExpression(Expression, TableValueType.Boolean, out errorMsg))
                {
                    lblValidation.Text = "Expression is valid";
                    lblValidation.ForeColor = Color.Green;
                    lblValidation.Font = new Font(lblValidation.Font, FontStyle.Bold);
                    return true;
                }

                lblValidation.Text = "Error: " + errorMsg;
                lblValidation.ForeColor = Color.Red;
                lblValidation.Font = new Font(lblValidation.Font, FontStyle.Bold);
            }

            if (!silent)
            {
                MessageService.Current.Info(lblValidation.Text);
            }

            return false;
        }

        private void InitFieldGrid()
        {
            fieldTypeGrid1.ShowColumnHeaders = false;
            var fields = Model.Layer.FeatureSet.Fields;
            var list = fields.Select(f => new FieldTypeWrapper(f)).ToList();

            fieldTypeGrid1.DataSource = list;
            fieldTypeGrid1.Adapter.SelectFirstRecord();

            fieldTypeGrid1.SelectedRecordsChanged += (s, e) =>
                {
                    if (chkShowValues.Checked)
                    {
                        ShowValues();
                    }
                };

            fieldTypeGrid1.TableControlCellDoubleClick += OnFieldGridDoubleClick;
        }

        private void InitTextBox()
        {
            richTextBox1.Text = Model.Expression;
            richTextBox1.HideSelection = false;
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }

        private void OnClearClicked(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void OnFieldGridDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            if (FieldIndex == -1) return;

            var fld = fieldTypeGrid1.Adapter.SelectedItem;
            if (fld != null)
            {
                richTextBox1.SelectedText = "[" + fld.Name + "] ";
            }
        }

        private void OnOperatorClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                richTextBox1.SelectedText = btn.Text + " ";
            }
        }

        private void OnShowValuesClicked(object sender, EventArgs e)
        {
            ShowValues();
        }

        private void OnValueDoubleClick(object sender, GridTableControlCellClickEventArgs e)
        {
            if (FieldIndex == -1) return;

            var fld = valueCountGrid1.Adapter.SelectedItem;
            if (fld != null)
            {
                richTextBox1.SelectedText = fld.Value + " ";
            }
        }

        private void ShowValues()
        {
            if (FieldIndex == -1)
            {
                return;
            }

            var list = _table.GetUniqueValues(FieldIndex).ToList();

            valueCountGrid1.DataSource = list;
        }
    }

    public class QueryBuilderViewBase : MapWindowView<QueryBuilderModel>
    {
    }
}