﻿// -------------------------------------------------------------------------------------------
// <copyright file="TaskNodeWrapper.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Controls;
using VastGIS.Tools.Helpers;
using Syncfusion.Windows.Forms.Tools;
using Action = System.Action;

namespace VastGIS.Tools.Views
{
    /// <summary>
    /// Wraps treeview nodes associated with a single task, allows to update them without rebuilding the whole tree.
    /// </summary>
    internal class TaskNodeWrapper
    {
        private readonly TreeViewAdv _treeView;
        private readonly IGisTask _task;
        private TreeNodeAdv _node;
        private ProgressBar _progress;

        public TaskNodeWrapper(TreeViewAdv treeView, IGisTask task)
        {
            if (treeView == null) throw new ArgumentNullException("treeView");
            if (task == null) throw new ArgumentNullException("task");

            _treeView = treeView;
            _task = task;

            GenerateNode();
        }

        public TreeNodeAdv Node
        {
            get { return _node; }
        }

        public ProgressBar Progress
        {
            get { return _progress; }
        }

        public IGisTask Task
        {
            get { return _task; }
        }

        public void UpdateStatus()
        {
            _node.Text = _task.Name;

            UpdateStatusIcon();

            if (Task.IsFinished)
            {
                HideProgress();
            }
        }

        private void AddProgressHandlers()
        {
            _task.Progress.ProgressChanged += (s, e) =>
                {
                    Action action = () =>
                    {
                        CreateBarProgress();
                        _progress.Value = e.Percent;
                    };

                    _treeView.SafeInvoke(action);
                };

            _task.Progress.Hide += (s, e) => _treeView.SafeInvoke(HideProgress);
        }

        private void CreateBarProgress()
        {
            if (!_task.IsFinished && _node.Nodes.Count == 0)
            {
                int width = Math.Min(100, _treeView.Width - 50);
                var ctrl = new ProgressBarWrapper { Width = width };
                _progress = ctrl.ProgressBar;

                var subNode = new TreeNodeAdv { Text = "", CustomControl = ctrl, IsSelectable = false };

                _node.Nodes.Clear();
                _node.Nodes.Add(subNode);
                _node.Expanded = true;
            }
        }

        private void GenerateNode()
        {
            _node = new TreeNodeAdv(_task.Name) { Tag = this };

            AddProgressHandlers();

            UpdateStatus();
        }

        private void HideProgress()
        {
            // CustomControl.Visible = false property doesn't work,
            // have to set custom control to null instead
            if (_node.Nodes.Count > 0)
            {
                _node.Nodes[0].CustomControl = null;
                _node.Nodes.Clear();
                _node.Expanded = false;
                
            }
        }

        private void UpdateStatusIcon()
        {
            var iconIndex = (int)_task.GetStatusIcon();
            _node.LeftImageIndices = new[] { iconIndex };
        }
    }
}