﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Concrete;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.TableEditor.Views.Abstract;
using VastGIS.UI.Forms;

namespace VastGIS.Plugins.TableEditor.Views
{
    public partial class JoinsView : JoinsBaseView, IJoinsView
    {
        public event Action JoinDoubleClicked
        {
            add { joinsGrid1.JoinDoubleClicked += value; }
            remove { joinsGrid1.JoinDoubleClicked -= value; }
        }

        public JoinsView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            UpdateView();
        }

        public override Mvp.ViewStyle Style
        {
            get
            {
                return new Mvp.ViewStyle()
                {
                    Modal = true,
                    Sizable = true,
                };
            }
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
                yield return btnJoin;
                yield return btnEditJoin;
                yield return btnStop;
                yield return btnStopAll;
            }
        }

        /// <summary>
        /// Updates state of the buttons after user actions
        /// </summary>
        public override void UpdateView()
        {
            var list = Model.Joins.ToList();
            joinsGrid1.DataSource = list;

            joinsGrid1.Adapter.SelectLastRow();

            var item = joinsGrid1.Adapter.SelectedItem;
            btnStop.Enabled =  item != null;
            btnEditJoin.Enabled = item != null;
            btnStopAll.Enabled = joinsGrid1.Adapter.Items.Any();
        }

        public FieldJoin SelectedJoin
        {
            get { return joinsGrid1.Adapter.SelectedItem; }
        }
    }

    public class JoinsBaseView : MapWindowView<IAttributeTable> { }
}
