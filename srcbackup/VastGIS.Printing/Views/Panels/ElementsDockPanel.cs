// -------------------------------------------------------------------------------------------
// <copyright file="ElementsDockPanel.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using VastGIS.Plugins.Mvp;
using VastGIS.UI.Controls;

namespace VastGIS.Plugins.Printing.Views.Panels
{
    public partial class ElementsDockPanel : DockPanelControlBase, IMenuProvider
    {
        public ElementsDockPanel()
        {
            InitializeComponent();
        }

        public IEnumerable<ToolStripItemCollection> ToolStrips
        {
            get { yield return toolStripEx1.Items; }
        }

        public IEnumerable<Control> Buttons
        {
            get { yield break; }
        }

        public void UpdateSelectionFromMap()
        {
            layoutListBox1.UpdateSelectionFromMap();

            bool hasSelection = layoutListBox1.LayoutControl.SelectedLayoutElements.Any();
            toolRemove.Enabled = hasSelection;
            toolMoveUp.Enabled = hasSelection;
            toolMoveDown.Enabled = hasSelection;
        }
    }
}