using System;
using System.Windows.Forms;
using OSGeo.GDAL;
using OSGeo.OGR;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmTestOgrChinese : Form
    {
        public frmTestOgrChinese()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogr.RegisterAll();
            Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
            Gdal.SetConfigOption("OGR_FORCE_ASCII", "YES");
            Gdal.SetConfigOption("SHAPE_ENCODING","GB2312");
            DataSource ds = Ogr.Open(txtDXF.Text, 0);

          richTextBox1.Clear();
            for (int i = 0; i < ds.GetLayerCount(); i++)
            {
                Layer pLayer = ds.GetLayerByIndex(i);
                Feature feat = pLayer.GetNextFeature();
                
                while (feat != null)
                {
                    
                    string lineStr = "";
                    for (int j = 0;j < 1;j++)
                    {
                        lineStr += feat.GetFieldDefnRef(j).GetName() + ":  " + feat.GetFieldAsString(j) + "; 长度: " + System.Text.UTF8Encoding.Default.GetBytes(feat.GetFieldAsString(j)).Length.ToString();
                    }
                   
                   richTextBox1.AppendText(lineStr+Environment.NewLine);

                    feat.Dispose();
                    feat = pLayer.GetNextFeature();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ogr.RegisterAll();
            Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
            Gdal.SetConfigOption("OGR_FORCE_ASCII", "YES");
            Gdal.SetConfigOption("SHAPE_ENCODING", "GB2312");
            DataSource ds = Ogr.Open(txtDB.Text, 0);
            Layer pLayer = ds.GetLayerByName("TmpCadzjView");
            Feature feat = pLayer.GetNextFeature();
            richTextBox1.Clear();
            while (feat != null)
            {
                string lineStr = "";
                for (int j = 0; j < feat.GetFieldCount(); j++)
                {
                    lineStr += feat.GetFieldDefnRef(j).GetName() + ":  " + feat.GetFieldAsString(j) + ";  ";
                }

                richTextBox1.AppendText(lineStr + Environment.NewLine);

                feat.Dispose();
                feat = pLayer.GetNextFeature();
            }
        }
    }
}
