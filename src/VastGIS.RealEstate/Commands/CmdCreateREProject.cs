using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.Plugins.RealEstate.Menu;
using VastGIS.Plugins.RealEstate.Properties;
using VastGIS.Plugins.Services;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.Services.Serialization;
using VastGIS.Shared;

namespace VastGIS.Plugins.RealEstate.Commands
{
    public class CmdCreateREProject : BaseCommand
    {
        private IAppContext _context;
        public CmdCreateREProject(IAppContext context)
        {
            base._text = "新建不动产项目";
            base._key = MenuKeys.NewREProject;
            base._icon = Resources.DatabaseServersFolder32;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExPrepare";
            _context = context;
        }

        public override void OnClick()
        {

            //IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            //projectService.TryClose();
            frmCreateDB frm = new frmCreateDB(_context);
            
            if (_context.View.ShowChildView(frm, true))
            {
                string projectFile = Path.Combine(frm.ProjectFile, frm.ProjectName, frm.ProjectName + ".vgproj");
                XmlProject project =
                    ReProjectHelper.CreateReProject(_context, frm.ProjectName, frm.ProjectFile, frm.EpsGCode);
                using (var writer = new StreamWriter(projectFile))
                {
                    writer.Write(project.Serialize());
                    writer.Flush();
                }
                //((ISecureContext) _context).VastProject = project;
                IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
                projectService.Open(projectFile, false);
            }
        }
    }
}
