﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VastGIS.Plugins.Mvp
{
    public interface ISubView: IMenuProvider
    {
        void Initialize();
    }
}
