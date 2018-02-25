﻿// -------------------------------------------------------------------------------------------
// <copyright file="TaskCollection.cs" company="VastGIS RealEstate Team -- www.vastgis.com.cn">
//  MapWindow OSS Team - 2015
// </copyright>
// -------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using VastGIS.Plugins.Enums;
using VastGIS.Plugins.Events;
using VastGIS.Plugins.Interfaces;

namespace VastGIS.Tools.Model
{
    /// <summary>
    /// Represents a collection of GIS tasks.
    /// </summary>
    internal class TaskCollection : ITaskCollection
    {
        private readonly List<IGisTask> _tasks = new List<IGisTask>();

        /// <summary>
        /// Occurs when all the tasks are cleared from the collection.
        /// </summary>
        public event EventHandler Cleared;

        /// <summary>
        /// Occurs when task status changes.
        /// </summary>
        public event EventHandler<TaskEventArgs> TaskChanged;

        /// <summary>
        /// Gets the number of tasks in the collection.
        /// </summary>
        public int Count
        {
            get { return _tasks.Count; }
        }

        /// <summary>
        /// Adds the specified task.
        /// </summary>
        /// <param name="task"></param>
        public void Add(IGisTask task)
        {
            task.StatusChanged += (s, e) => FireTaskChanged(e.Task, TaskEvent.StatusChanged);
            _tasks.Add(task);
            FireTaskChanged(task, TaskEvent.Added);
        }

        /// <summary>
        /// Removes the specified task.
        /// </summary>
        /// <param name="task">The task.</param>
        public void Remove(IGisTask task)
        {
            _tasks.Remove(task);
            FireTaskChanged(task, TaskEvent.Removed);
        }

        /// <summary>
        /// Removed all the tasks from the collection.
        /// </summary>
        /// <param name="finishedOnly">If set to <c>true</c> only finished tasks will be removed.</param>
        public void Clear(bool finishedOnly)
        {
            if (finishedOnly)
            {
                lock (_tasks)
                {
                    for (int i = _tasks.Count - 1; i >= 0; i--)
                    {
                        var task = _tasks[i];
                        if (task.IsFinished)
                        {
                            Remove(task);
                        }
                    }
                }
            }
            else
            {
                _tasks.Clear();
                FireCollectionCleared();    
            }
        }

        /// <summary>
        /// Cancels all the running tasks.
        /// </summary>
        public void CancelAll()
        {
            foreach (var t in this)
            {
                if (!t.IsFinished)
                {
                    t.Cancel();
                }
            }
        }

        public IEnumerator<IGisTask> GetEnumerator()
        {
            return _tasks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void FireCollectionCleared()
        {
            var handler = Cleared;
            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

        private void FireTaskChanged(IGisTask task, TaskEvent taskEvent)
        {
            var handler = TaskChanged;
            if (handler != null)
            {
                handler(this, new TaskEventArgs(task, taskEvent));
            }
        }
    }
}