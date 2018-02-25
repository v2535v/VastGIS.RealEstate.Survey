// -------------------------------------------------------------------------------------------
// <copyright file="GeoLocationView.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.UI.Forms;
using VastGIS.UI.Helpers;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    public partial class GeoLocationView : MapWindowView, IGeoLocationView
    {
        public GeoLocationView()
        {
            InitializeComponent();

            InitControls();

            AttachEvents();

            UpdateView();
        }

        private void AttachEvents()
        {
            optKnownExtents.CheckedChanged += (s, e) => UpdateView();
        }

        public ButtonBase OkButton
        {
            get { return btnOk; }
        }

        public string LocationQuery
        {
            get { return txtFindLocation.Text; }
        }

        public KnownExtents KnownExtents
        {
            get { return cboKnownExtents.GetValue<KnownExtents>(); }
        }

        public bool UseGeoLocation
        {
            get { return optFindLocation.Checked; }
        }

        public event Action Search;

        public void SetInputFocus()
        {
            if (txtFindLocation.Enabled)
            {
                txtFindLocation.Focus();
                txtFindLocation.SelectAll();
            }
        }

        private void InitControls()
        {
            cboKnownExtents.AddItemsFromEnum<KnownExtents>();

            cboKnownExtents.SetValue(KnownExtents.None);
        }

        public override void UpdateView()
        {
            cboKnownExtents.Enabled = optKnownExtents.Checked;
            txtFindLocation.Enabled = optFindLocation.Checked;
        }
    }
}