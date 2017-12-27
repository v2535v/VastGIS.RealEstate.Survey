using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Menu;
using VastGIS.Plugins.Concrete;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Services;
using VastGIS.Properties;
using VastGIS.RealEstate.Api.Helpers;
using VastGIS.RealEstateDB.Forms;
using VastGIS.Services.Serialization;
using VastGIS.Shared;

namespace VastGIS.Commands.File
{
    public class CmdCreateNewProject : BaseCommand
    {
        private IAppContext _context;
        public CmdCreateNewProject(IAppContext context)
        {
            base._text = "新建项目";
            base._key = MenuKeys.NewProject;
            base._icon = Resources.icon_new_map;
            base._headerName = "tabFile";
            base._toolStripExName = "toolStripExFile";
            _context = context;
        }

        public override void OnClick()
        {

            //IProjectService projectService = _context.Container.GetSingleton<IProjectService>();
            //projectService.TryClose();
            frmCreateDB frm = new frmCreateDB();
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
