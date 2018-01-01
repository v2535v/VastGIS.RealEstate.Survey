using System.IO;
using System.Windows.Forms;
using VastGIS.UI.Forms;

namespace VastGIS.Services.Views
{
    public partial class ProjectLoadingView : MapWindowView
    {
        public ProjectLoadingView()
        {
            InitializeComponent();
        }

        public ProjectLoadingView(string projectName)
        {
            InitializeComponent();

            Text = "项目: " + Path.GetFileNameWithoutExtension(projectName);
        }

        public ProjectLoadingView(string projectName,bool isUseProjectPre)
        {
            InitializeComponent();

            Text = isUseProjectPre?  "项目: " + Path.GetFileNameWithoutExtension(projectName) : projectName;
        }

        public void SetTitle(string title)
        {
            Text = title;
        }

        public override Plugins.Mvp.ViewStyle Style
        {
            get { return new Plugins.Mvp.ViewStyle() { Modal = false, Sizable = false }; }
        }

        public void ShowProgress(int percent, string message)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;

            progressBarAdv1.Value = percent;
            progressBarAdv1.Refresh();

            lblMessage.Text = message;
            lblMessage.Refresh();

            Application.DoEvents();
        }

        public void ShowProgress(int percent, string message,string title)
        {
            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;

            progressBarAdv1.Value = percent;
            progressBarAdv1.Refresh();

            lblMessage.Text = message;
            lblMessage.Refresh();
            Text = title;
            this.Refresh();
            Application.DoEvents();
        }


    }
}
