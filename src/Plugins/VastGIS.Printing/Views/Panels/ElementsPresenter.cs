// -------------------------------------------------------------------------------------------
// <copyright file="ElementsPresenter.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Printing.Controls.Layout;
using VastGIS.Plugins.Printing.Enums;

namespace VastGIS.Plugins.Printing.Views.Panels
{
    internal class ElementsPresenter : CommandDispatcher<ElementsDockPanel, ElementsCommand>, IDockPanelPresenter
    {
        private LayoutControl _layoutControl;

        public ElementsPresenter(ElementsDockPanel view)
            : base(view)
        {
        }

        public Control GetInternalObject()
        {
            return View;
        }

        public override void RunCommand(ElementsCommand command)
        {
            switch (command)
            {
                case ElementsCommand.MoveUp:
                    _layoutControl.MoveSelectionUp();
                    break;
                case ElementsCommand.MoveDown:
                    _layoutControl.MoveSelectionDown();
                    break;
                case ElementsCommand.Remove:
                    _layoutControl.DeleteSelected();
                    break;
                default:
                    throw new ArgumentOutOfRangeException("command");
            }
        }

        public void SetLayoutControl(LayoutControl layoutControl)
        {
            View.layoutListBox1.LayoutControl = layoutControl;
            _layoutControl = layoutControl;
        }
    }
}