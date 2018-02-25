using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Controls;
using VastGIS.Enums;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface IAboutView: IView
    {
        string OcxVersion { set; }
        List<AssemblyInfo> Assemblies { set; }
        AssemblyFilter AssemblyFilter { get; set; }
        event Action AssemblyFilterChanged;
    }
}
