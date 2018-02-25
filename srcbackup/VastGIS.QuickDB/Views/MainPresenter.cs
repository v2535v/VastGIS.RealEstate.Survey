using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.QuickDB.Interface;
using VastGIS.QuickDB.Mvp;

namespace VastGIS.QuickDB.Views
{
    public class MainPresenter:BasePresenter<IMainView>
    {
        private readonly IAppContext _context;

        public MainPresenter(IAppContext context,IMainView view )
            : base(view)
        {
            if (view == null) throw new ArgumentNullException("view");

            _context = context;
            var appContext = context as AppContext;
            if (appContext == null)
            {
                throw new InvalidCastException("Invalid type of IAppContext instance");
            }

            appContext.Init(view);
            View.AsForm.Shown += ViewShown;
        }
        public override bool ViewOkClicked()
        {
            return true; // there is no ok button
        }

        private void ViewShown(object sender, EventArgs e)
        {
            Application.DoEvents();
           
        }
    }
}
