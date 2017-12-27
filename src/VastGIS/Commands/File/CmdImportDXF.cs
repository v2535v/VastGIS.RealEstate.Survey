using System.Windows.Forms;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Properties;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.Services.Views;

namespace VastGIS.Commands.File
{
    public class CmdImportDXF : BaseCommand
    {
        private IAppContext _context;
        public CmdImportDXF(IAppContext context)
        {
            base._text = "导入DXF";
            base._key = MenuKeys.ImportDXF;
            base._icon = Resources.img_layers32;
            base._headerName = "tabReady";
            base._toolStripExName = "toolStripReadies";
            _context = context;
        }

        public override void OnClick()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "DXF图形(*.dxf)|*.dxf";
            if (dialog.ShowDialog() != DialogResult.OK) return;
            if (((IRealEstateContext)_context).RealEstateDatabase == null)
            {
                ((IRealEstateContext)_context).CheckDatabase();
            }
            {
                ProjectLoadingView _loadingForm;
                _loadingForm = new ProjectLoadingView("导入DXF操作:" + dialog.FileName);
                _context.View.ShowChildView(_loadingForm, false);
                Application.DoEvents();
                _context.View.Lock();
                ((IRealEstateContext)_context).RealEstateDatabase.ImportDxfDrawing(dialog.FileName, _loadingForm);
                _context.View.Unlock();
                _loadingForm.Close();
                _loadingForm.Dispose();
            }
        }
    }
}