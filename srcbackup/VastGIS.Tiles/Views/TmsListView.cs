﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Model;
using VastGIS.Plugins.Mvp;
using VastGIS.Tiles.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Tiles.Views
{
    internal partial class TmsListView : ProvidersViewBase, IProvidersView
    {
        public TmsListView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called before view is shown. Allows to initialize UI from this.Model property.
        /// </summary>
        public void Initialize()
        {
            tileProviderGrid1.DataSource = Model.DataSource;
        }

        public override ViewStyle Style
        {
            get { return new ViewStyle(true); }
        }

        public ButtonBase OkButton
        {
            get { return btnClose; }
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield break; }
        }

        public IEnumerable<Control> Buttons
        {
            get
            {
                yield return btnAdd;
                yield return btnEdit;
                yield return btnRemove;
                yield return btnClear;
            }
        }

        public TmsProvider SelectedProvider
        {
            get { return tileProviderGrid1.Adapter.SelectedItem; }
        }
    }

    internal class ProvidersViewBase: MapWindowView<TmsProviderList> { }
}

   
