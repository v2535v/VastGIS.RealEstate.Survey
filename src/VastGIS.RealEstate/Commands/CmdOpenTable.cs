using System;
using System.Windows.Forms;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate;
using VastGIS.Plugins.RealEstate.Attribute;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Helpers;
using VastGIS.Shared;

namespace VastGIS.Commands.File
{
    public class CmdOpenTable : BaseCommand
    {
        private IAppContext _context;
        private RealEstateEditor _plugin;
        public CmdOpenTable(IAppContext context,RealEstateEditor plugin)
        {
            base._text = "打开属性表";
            base._key = MenuKeys.OpenTable;
            base._icon = Resources.img_opentable;
            base._headerName = "tabZD";
            base._toolStripExName = "toolStripExZDTable";
            _context = context;
            _plugin = plugin;
        }

        public override void OnClick()
        {
            frmEditTable frm = new frmEditTable(_context,_plugin);
            if (frm.ShowDialog() != DialogResult.OK) return;
            VgObjectclass objectClass = frm.SelectedObjectClass();
            if (objectClass == null) return;

            string objectName = "VastGIS.Plugins.RealEstate.Attribute.frm" + StringUtil.GetEntityName(objectClass.Mc);
            Type entityType = Type.GetType(objectName);
            if (entityType != null)
            {
                IAttributeForm pForm = Activator.CreateInstance(entityType) as IAttributeForm;
                pForm.BindContext(_context,objectClass);
                ((Form)pForm).ShowDialog();
            }
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "DXF图形(*.dxf)|*.dxf";
            //if (dialog.ShowDialog() != DialogResult.OK) return;
            //if (((IRealEstateContext)_context).RealEstateDatabase == null)
            //{
            //    ((IRealEstateContext)_context).CheckDatabase();
            //}

            //    ProjectLoadingView _loadingForm;
            //    _loadingForm = new ProjectLoadingView("导入DXF操作:" + dialog.FileName);
            //    _context.View.ShowChildView(_loadingForm, false);
            //    Application.DoEvents();
            //    _context.View.Lock();
            //    ((IRealEstateContext)_context).RealEstateDatabase.ImportDxfDrawing(dialog.FileName, _loadingForm);
            //    _context.View.Unlock();
            //    _loadingForm.Close();
            //    _loadingForm.Dispose();

        }
    }
}