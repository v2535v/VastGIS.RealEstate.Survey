using System.Windows.Forms;
using VastGIS.Api.Interfaces;
using VastGIS.Api.Static;
using VastGIS.Plugins.Mvp;
using VastGIS.Shared;
using VastGIS.Views.Abstract;

namespace VastGIS.Views
{
    public class CreatePyramidsPresenter: BasePresenter<ICreatePyramidsView, IRasterSource>
    {
        public CreatePyramidsPresenter(ICreatePyramidsView view) : base(view)
        {
            view.ButtonClicked += OnButtonClicked;
        }

        public DialogResult Result
        {
            get
            {
                var form = View as Form;
                return form != null ? form.DialogResult : DialogResult.Cancel;
            }
        }

        public bool DontShowAgain
        {
            get { return View.DontShowAgain; }
        }

        private void OnButtonClicked()
        {
            if (Result == DialogResult.Yes)
            {
                // warning is displayed by MapWinGIS
                Model.BuildDefaultOverviews(View.Sampling, View.Compression);
            }
            
            ReturnValue = Result != DialogResult.Cancel;
            View.Close();
        }

        public override bool ViewOkClicked()
        {
            return true;
        }
    }
}
