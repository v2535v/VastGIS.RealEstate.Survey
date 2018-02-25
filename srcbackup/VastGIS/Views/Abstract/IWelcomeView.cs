using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Views.Abstract
{
    public interface IWelcomeView: IView<WelcomeViewModel>
    {
        event Action GettingStartedClicked;
        event Action DocumentsClicked;
        event Action DonateClicked;
        event Action OpenLayerClicked;
        event Action OpenProjectClicked;
        event Action LogoClicked;

        int ProjectId { get; }
    }
}
