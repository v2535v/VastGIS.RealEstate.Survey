using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VastGIS.RealEstate.Data;
using VastGIS.Services.Views;

namespace VastGIS.RealEstate.Api.Interface
{
    public interface IREDatabase
    {
        string DatabaseName { get; set; }
        int EpsgCode { get; set; }
        List<IObjectClass> GetObjectClasses();
        List<IObjectClass> GetClasses(bool IsRecursion = true);
        bool InitREDatabase(int epsgCode,ProjectLoadingView loadingForm,out string errorMsg);
        ICodeDomain GetDomain(string domainName);
        bool CheckDatabase();
        void ImportDxfDrawing(string dxfName, ProjectLoadingView loadingForm);
    }

    public interface IRealEstateContext
    {
       IREDatabase RealEstateDatabase { get; set; }

        bool CheckDatabase();
    }
}
