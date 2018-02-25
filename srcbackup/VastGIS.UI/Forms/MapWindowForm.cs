﻿// -------------------------------------------------------------------------------------------
// <copyright file="MapWindowForm.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2016
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Drawing;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Properties;
using Syncfusion.Windows.Forms;

namespace VastGIS.UI.Forms
{
#if STYLE2010
    public partial class MapWindowForm : Office2010Form
#else
    public class MapWindowForm : MetroForm
#endif
    {
        protected readonly IAppContext _context;

        public MapWindowForm()
        {
            Icon = Resources.img_logo24;
#if STYLE2010
            ApplyAeroTheme = false;
            UseOffice2010SchemeBackColor = true;
#endif
        }

        public MapWindowForm(IAppContext context)
            : this()
        {
            _context = context;
        }

        public IAppContext AppContext
        {
            get { return _context; }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // MapWindowForm
            // 
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MapWindowForm";
            this.Load += new System.EventHandler(this.MapWindowForm_Load);
            this.ResumeLayout(false);

        }

        private void MapWindowForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}