﻿using System;
using System.Drawing;
using System.Windows.Forms;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.QuickDB.Concrete;
using VastGIS.QuickDB.Interface;
using VastGIS.QuickDB.Views;
using Action = System.Action;

namespace VastGIS.UI.Forms
{

    public partial class MainWindowView : RibbonForm, IViewInternal

    {
        public event Action OkClicked;

        protected MainWindowView()
        {
            //Logger.Current.Trace("Start MapWindowView");
            //Logger.Current.Trace("Start MapWindowView.InitializeComponent()");
            InitializeComponent();
            //Logger.Current.Trace("End MapWindowView.InitializeComponent()");
           
        }

        protected void Invoke(Action action)
        {
            if (action != null)
            {
                action();
            }
        }

        public virtual void ShowView(IWin32Window parent = null)
        {
            if (!Visible)
            {
                AppViewFactory.Instance.ShowChildView(this, parent);
            }
        }

        public virtual ViewStyle Style
        {
            get
            {
                return new ViewStyle()
                {
                    Modal = true,
                    Sizable = false,
                };
            }
        }

        public virtual void BeforeClose()
        {
            // default implementation; can be overriden in child classes
        }

        public virtual void UpdateView()
        {
            // default implementation; can be overriden in child classes
        }

        protected void FireOkClicked()
        {
            Invoke(OkClicked);
        }

        public void StartWait()
        {
            Cursor = Cursors.WaitCursor;

            EnableControls(false);

            Application.DoEvents();
        }

        public void StopWait()
        {
            Cursor = Cursors.Default;

            EnableControls(true);

            Application.DoEvents();
        }

        private void EnableControls(bool state)
        {
            foreach (Control ctrl in Controls)
            {
                ctrl.Enabled = state;
            }
        }

        public Form AsForm
        {
            get { return this; }
        }

        private void MapWindowView_Load(object sender, EventArgs e)
        {
            // Fixing CORE-160
            //CaptionFont = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        }
    }



}
