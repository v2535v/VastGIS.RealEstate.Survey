﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.TableEditor.Model;
using VastGIS.Plugins.TableEditor.Properties;
using VastGIS.UI.Controls;

namespace VastGIS.Plugins.TableEditor.Controls
{
    internal partial class RecalculateFieldsGrid : StronglyTypedGrid<RecalculateFieldWrapper>
    {
        private readonly ImageList _imageList = new ImageList();

        public RecalculateFieldsGrid()
        {
            InitializeComponent();

            Adapter.HotTracking = true;
            Adapter.ReadOnly = false;
            Adapter.AllowCurrentCell = false;

            InitImageList();
        }

        private void InitImageList()
        {
            _imageList.Images.Clear();
            _imageList.ColorDepth = ColorDepth.Depth32Bit;
            _imageList.ImageSize = new Size(16, 16);
            _imageList.Images.Add(Resources.img_error16);
            _imageList.Images.Add(Resources.img_warning16);
            _imageList.Images.Add(Resources.img_ok16);
        }

        protected override void UpdateColumns()
        {
            Adapter.HideColumns();

            Adapter.ShowColumn(f => f.Selected);
            Adapter.ShowColumn(f => f.Name);
            Adapter.ShowColumn(f => f.Expression);
            Adapter.ShowColumn(f => f.Details);

            Adapter.GetColumn(f => f.Details).Width = 150;
            Adapter.GetColumnStyle(f => f.Details).ImageList = _imageList;
            Adapter.SetColumnIcon(f => f.Details, GetIcon);
        }

        private int GetIcon(RecalculateFieldWrapper field)
        {
            switch (field.Result)
            {
                case RecalculateFieldResult.None:
                    return -1;
                case RecalculateFieldResult.Failure:
                    return 0;
                case RecalculateFieldResult.SomeRows:
                    return 1;
                case RecalculateFieldResult.Success:
                    return 2;
            }

            return -1;
        }
    }
}
