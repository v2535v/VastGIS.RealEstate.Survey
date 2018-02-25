﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Services.Controls;
using VastGIS.Services.Views.Abstract;

namespace VastGIS.Services.Views
{
    public class MissingLayersPresenter: BasePresenter<IMissingLayersView, List<MissingLayer>>
    {
        public MissingLayersPresenter(IMissingLayersView view) : base(view)
        {
        }

        public bool ValidateModel()
        {
            if (Model.Exists(l => !File.Exists(l.Filename)))
            {
                return MessageService.Current.Ask("Datasources for some of the layers are still missing. " + Environment.NewLine +
                                                  "Do you want to open project without them?");
                
            }

            return true;
        }

        public override bool ViewOkClicked()
        {
            return ValidateModel();
        }
    }
}
