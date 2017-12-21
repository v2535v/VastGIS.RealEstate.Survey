using System.Diagnostics;
using System.Windows.Forms;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Mvp.Sample
{
    public class SamplePresenter : ComplexPresenter<ISampleView, SampleCommand, SampleViewModel>
    {
        private readonly ISampleView _view;

        public SamplePresenter(ISampleView view)
            : base(view)
        {
            _view = view;
        }

        protected override void Initialize()
        {
            Debug.Print("Layer name passed as parameter: " + Model.Name);
        }

        public override void RunCommand(SampleCommand command)
        {
            switch (command)
            {
                case SampleCommand.TestButton:
                    MessageBox.Show("Button is clicked");
                    break;
                case SampleCommand.TestMenu:
                    MessageBox.Show("Menu is clicked");
                    break;
            }
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
