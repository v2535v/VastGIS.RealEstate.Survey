﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Plugins.Interfaces;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.Forms
{
    public partial class frmDCJS : Form
    {
        private IAppContext _context;
        private IREDatabase _database;
        private IGlobalEntity _linkedObject;
        private string _names;
        private string _zjs;
        private string _gkj;
       
        public frmDCJS()
        {
            InitializeComponent();
            _names = "";
            _zjs = "";
            _gkj = "";
          
        }

        public IAppContext Context
        {
            get { return _context; }
            set
            {
                _context = value;
                _database = ((IRealEstateContext)_context).RealEstateDatabase;
            }
        }

        public void LoadEntity(IEntity entity,string memo)
        {
            _linkedObject = entity as IGlobalEntity;
            txtJS.Text = memo;
        }

        private void btnQLR_Click(object sender, EventArgs e)
        {
            IEnumerable<Qlr> enumQlrs = _database.ZdService.GetQlrs("WX_WYDM='" + _linkedObject.WxWydm + "'");
            if(enumQlrs==null) return;
            List<Qlr> qlrs = enumQlrs.ToList();
            frmQLRXZ frm=new frmQLRXZ(qlrs);
            DialogResult back = frm.ShowDialog();
            if (back != DialogResult.OK) return;
            _names = frm.GetMemo();
            BuildMemo();
        }

        private void BuildMemo()
        {
            StringBuilder builder=new StringBuilder();
            builder.Append("经调查:");
            if (_linkedObject is Zdjbxx)
            {
                builder.Append("该宗地使用人");
            }
            builder.Append(_names);
            builder.Append("使用人提供了");
            builder.Append(_zjs);
            builder.Append("。");
            builder.Append(_gkj);

            if (txtJS.SelectionLength > 0)
            {
                //如果有选中的内容，则将光标移动到被选中内容之后
                txtJS.SelectionStart = txtJS.SelectionStart + txtJS.SelectionLength;
            }
            txtJS.SelectedText = builder.ToString();

        }

        private void btnZJ_Click(object sender, EventArgs e)
        {
            frmZJXZ frm=new frmZJXZ();
            if(frm.ShowDialog() == DialogResult.OK)
            _zjs = frm.GetMemo();
        }

        private void btnGKJ_Click(object sender, EventArgs e)
        {
            frmGKJ frm = new frmGKJ();
            if (frm.ShowDialog() == DialogResult.OK)
                _gkj = frm.GetMemo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtJS.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string GetMemo()
        {
            return txtJS.Text;
        }
    }
}
