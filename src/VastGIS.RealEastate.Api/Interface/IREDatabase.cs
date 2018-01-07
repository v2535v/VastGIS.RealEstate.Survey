using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Api.Interfaces;
using VastGIS.RealEstate.Api.Enums;
using VastGIS.RealEstate.Data;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Enums;
using VastGIS.RealEstate.Data.Service;
using VastGIS.Services.Views;

namespace VastGIS.RealEstate.Api.Interface
{
    public interface IREDatabase
    {
        void SetProjectFile(string fileName);
        string DatabaseName { get; set; }

        int EpsgCode { get; set; }

        bool IsEmpty { get; }

        bool CheckDatabase();

        CadService CadService { get; }

        BasemapService BasemapService { get; }
        SystemService SystemService { get; }

        DomainService DomainService { get; }

        ZdService ZdService { get; }

        void InitDatabase(int epsgCode);

        void LoadDataToMap(IMuteMap contextMap);
    }

   
}
