using System;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.UI.Properties;

namespace VastGIS.UI.Forms
{
    public  class MapEditingForm :Form// Office2010Form
    {
        protected readonly IAppContext _context;

        public MapEditingForm()
        {
            Icon = Resources.img_logo24;
        }

        public MapEditingForm(IAppContext context)
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
           // this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "MapWindowForm";
            this.Load += new System.EventHandler(this.MapEditingForm_Load);
            this.ResumeLayout(false);

        }
        private void MapEditingForm_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
           // CaptionFont = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }
}
