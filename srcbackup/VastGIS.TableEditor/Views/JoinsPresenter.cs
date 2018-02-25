using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Attributes.Helpers;
using VastGIS.Attributes.Views;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Plugins.TableEditor.Views.Abstract;

namespace VastGIS.Plugins.TableEditor.Views
{
    public class JoinsPresenter: ComplexPresenter<IJoinsView, JoinsCommand, IAttributeTable>
    {
        private readonly IAppContext _context;

        public JoinsPresenter(IAppContext context, IJoinsView view) : base(view)
        {
            if (context == null) throw new ArgumentNullException("context");

            _context = context;

            View.JoinDoubleClicked += () => RunCommand(JoinsCommand.EditJoin);
        }

        public override void RunCommand(JoinsCommand command)
        {
            switch (command)
            {
                case JoinsCommand.Join:
                    if (JoinHelper.AddJoin(_context, Model))
                    {
                        View.UpdateView();
                    }
                    break;
                case JoinsCommand.EditJoin:
                    if (JoinHelper.EditJoin(_context, Model, View.SelectedJoin))
                    {
                        View.UpdateView();
                    }
                    break;
                case JoinsCommand.Stop:
                    if (JoinHelper.StopJoin(Model, View.SelectedJoin))
                    {
                        View.UpdateView();
                    }
                    break;
                case JoinsCommand.StopAll:
                    JoinHelper.StopAllJoins(Model);
                    break;
                default:
                    throw new ArgumentOutOfRangeException("command");
            }
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
