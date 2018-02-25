﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.DebugWindow.Views.Abstract;
using VastGIS.Plugins.Interfaces;
using VastGIS.Plugins.Mvp;
using VastGIS.Plugins.Services;
using VastGIS.Shared;

namespace VastGIS.Plugins.DebugWindow.Views
{
    public class DebugPresenter: CommandDispatcher<IDebugView, DebugCommand>, IDockPanelPresenter
    {
        private readonly DebugDockView _debugDockView;

        public DebugPresenter(DebugDockView debugDockView)
            :base(debugDockView)
        {
            if (debugDockView == null) throw new ArgumentNullException("debugDockView");
            _debugDockView = debugDockView;
        }

        public Control GetInternalObject()
        {
            return _debugDockView;
        }

        public override void RunCommand(DebugCommand command)
        {
            switch (command)
            {
                case DebugCommand.ClearLog:
                    View.Clear();
                    break;
                case DebugCommand.ClearFilter:
                    MessageService.Current.Info("Not implemented");
                    break;
            }
        }
    }
}
