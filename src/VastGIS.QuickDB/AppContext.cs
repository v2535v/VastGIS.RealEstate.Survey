using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.QuickDB.Interface;
using VastGIS.QuickDB.Views;

namespace VastGIS.QuickDB
{
    public class AppContext:IAppContext
    {
        private readonly IApplicationContainer _container;
        private IBDCDatabase _currentDatabase;

        public AppContext(IApplicationContainer container)
        {
            _container = container;
        }

        public IApplicationContainer Container
        {
            get { return _container; }
        }

        public IBDCDatabase CurrentDatabase
        {
            get { return _currentDatabase; }
        }
       
        public IAppView View { get; private set; }

        internal void Init(IMainView mainView)
        {
            if (mainView == null) throw new ArgumentNullException("mainView");
            View = new AppView(mainView);
        }
    }
}
