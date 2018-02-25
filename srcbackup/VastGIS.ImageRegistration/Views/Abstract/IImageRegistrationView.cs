using System;
using VastGIS.Api.Interfaces;
using VastGIS.Plugins.Mvp;

namespace VastGIS.Plugins.ImageRegistration.Views.Abstract
{
    interface IImageRegistrationView : IComplexView<ImageRegistrationModel>
    {
        void AddSourceImage(IImageSource image);

        void RemoveTransformedImage();

        void LoadTransformedImage();

        event Action RecalculationNeeded;
    }
}
