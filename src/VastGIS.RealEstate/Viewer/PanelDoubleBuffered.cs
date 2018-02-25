namespace VastGIS.Plugins.RealEstate.Viewer
{
    public class PanelDoubleBuffered : System.Windows.Forms.Panel
    {
        public PanelDoubleBuffered()
        {
            this.DoubleBuffered = true;
            this.UpdateStyles();
        }
    }
}