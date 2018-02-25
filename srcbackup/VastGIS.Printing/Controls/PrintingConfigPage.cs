using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Printing.Enums;
using VastGIS.Plugins.Printing.Helpers;
using VastGIS.Plugins.Printing.Properties;
using VastGIS.UI.Controls;
using VastGIS.UI.Helpers;

namespace VastGIS.Plugins.Printing.Controls
{
    public partial class PrintingConfigPage : ConfigPageBase, IConfigPage
    {
        public PrintingConfigPage()
        {
            InitializeComponent();

            InitControls();

            Initialize();
        }

        private void InitControls()
        {
            cboUnits.AddItemsFromEnum<LayoutUnit>();
            cboOrientation.AddItemsFromEnum<Orientation>();
        }

        public string Description
        {
            get { return "Settings of layout plug-in and printing."; }
        }

        public Bitmap Icon
        {
            get { return Resources.img_printer32; }
        }

        public string PageName
        {
            get { return "Printing"; }
        }

        public ConfigPageType PageType
        {
            get { return ConfigPageType.Printing; }
        }

        public override ConfigPageType ParentPage
        {
            get { return ConfigPageType.Plugins; }
        }

        /// <summary>
        /// Gets a value indicating whether the page height can be adjusted to fit the the parent.
        /// </summary>
        public bool VariableHeight 
        {
            get { return false; } 
        }

        public void Initialize()
        {
            cboUnits.SetValue(ConfigHelper.GetUnits());
            cboOrientation.SetValue(AppConfig.Instance.PrintingOrientation);
            txtFormat.Text = AppConfig.Instance.PrintingPaperFormat;
        }

        public void Save()
        {
            AppConfig.Instance.PrintingUnits = (int)cboUnits.GetValue<LayoutUnit>();
            AppConfig.Instance.PrintingOrientation = cboOrientation.GetValue<Orientation>();
        }
    }
}
