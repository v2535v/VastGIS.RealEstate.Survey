﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;
using VastGIS.Shared;
using VastGIS.Tools.Enums;
using VastGIS.Tools.Properties;
using VastGIS.UI.Controls;
using Syncfusion.Windows.Forms.Tools;
using Action = System.Action;

namespace VastGIS.Tools.Views
{
    public partial class TasksTreeView : TreeViewBase
    {
        private ITaskCollection _tasks;
        private TreeNodeAdv _rootNode;

        public TasksTreeView()
        {
            InitializeComponent();

            ShowSuperTooltip = false;
        }

        protected override IEnumerable<Bitmap> OnCreateImageList()
        {
            // must match TaskIcons enumeration
            yield return Resources.img_wait16;
            yield return Resources.img_ok16;
            yield return Resources.img_error16;
            yield return Resources.img_database16;
            yield return Resources.img_result16;
            yield return Resources.img_options24;
            yield return Resources.img_warning16;
            yield return Resources.img_cancel16;
            yield return Resources.img_pause16;
            yield return Resources.img_tasks16;
            yield return Resources.img_clock16;
        }

        /// <summary>
        /// Attempting to override default keyboard navigation (disabled for now).
        /// </summary>
        private void OnTreeKeyDown(object sender, KeyEventArgs e)
        {
            if (SelectedNode == null) return;

            if (SelectedNode.Parent == null || SelectedNode.Parent != _rootNode)
            {
                return;
            }

            if (e.KeyCode == Keys.Down && SelectedNode.NextSelectableNode != null)
            {
                SelectedNode = SelectedNode.NextSelectableNode;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Up && SelectedNode.PrevSelectableNode != null)
            {
                SelectedNode = SelectedNode.PrevSelectableNode;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                SelectedNode.Expanded = false;
                e.Handled = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                SelectedNode.Expanded = true;
                e.Handled = true;
            }
        }

        private void AddRootNode()
        {
            Nodes.Clear();

            _rootNode = new TreeNodeAdv("All tasks".ToUpper())
                            {
                                Expanded = true, 
                                LeftImageIndices = new[] { (int)TaskIcons.Tasks}
                            };
            _rootNode.Height += 5;
            Nodes.Add(_rootNode);
        }

        public void Initialize(ITaskCollection tasks)
        {
            AddRootNode();

            if (tasks == null) throw new ArgumentNullException("tasks");
            _tasks = tasks;
            _tasks.TaskChanged += OnTaskChanged;
            _tasks.Cleared += OnTasksCleared;
        }

        private void OnTasksCleared(object sender, EventArgs e)
        {
            _rootNode.Nodes.Clear();
            Controls.Clear();
        }

        private void OnTaskChanged(object sender, TaskEventArgs e)
        {
            Action action = () =>
                {

                    switch (e.Event)
                    {
                        case TaskEvent.Added:
                            {
                                var wrapper = new TaskNodeWrapper(this, e.Task);
                                var node = wrapper.Node;
                                _rootNode.Nodes.Add(node);
                                
                                // let's aumatically select it, which will display the stats
                                SelectedNode = node;
                            }
                            break;
                        case TaskEvent.StatusChanged:
                            {
                                var wrapper = FindTask(e.Task);
                                if (wrapper != null)
                                {
                                    wrapper.UpdateStatus();
                                }
                            }
                            break;
                        case TaskEvent.Removed:
                            {
                                var wrapper = FindTask(e.Task);
                                if (wrapper != null)
                                {
                                    _rootNode.Nodes.Remove(wrapper.Node);
                                    Controls.Remove(wrapper.Progress);
                                }
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                };

            this.SafeInvoke(action);

        }

        private TaskNodeWrapper FindTask(IGisTask task)
        {
            foreach (TreeNodeAdv node in _rootNode.Nodes)
            {
                var wrapper = WrapperForNode(node);
                if (wrapper != null && wrapper.Task == task)
                {
                    return wrapper;
                }
            }

            return null;
        }

        private TaskNodeWrapper WrapperForNode(TreeNodeAdv node)
        {
            return node.Tag as TaskNodeWrapper;
        }

        public IGisTask SelectedTask
        {
            get
            {
                var node = SelectedNode;
                if (node == null)
                {
                    return null;
                }

                var wrapper = node.Tag as TaskNodeWrapper;
                if (wrapper != null)
                {
                    return wrapper.Task;
                }

                return null;
            }
        }
    }
}

