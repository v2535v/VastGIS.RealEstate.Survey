using System;
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
        private string _qlr;
        private string _qlrbh;
        private string _zjs;
        //private string _gkj;
        private GKJ _gkj;

        public frmDCJS()
        {
            InitializeComponent();
            _qlr = "";
            _qlrbh = "";
            _zjs = "";
            _gkj = null;

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

        public void LoadEntity(IEntity entity, string memo)
        {
            _linkedObject = entity as IGlobalEntity;
            txtJS.Text = memo;
        }

        private void btnQLR_Click(object sender, EventArgs e)
        {
            IEnumerable<Qlr> enumQlrs = _database.ZdService.GetQlrs("WX_WYDM='" + _linkedObject.WxWydm + "'");
            if (enumQlrs == null) return;
            List<Qlr> qlrs = enumQlrs.ToList();
            frmQLRXZ frm = new frmQLRXZ(qlrs);
            DialogResult back = frm.ShowDialog();
            if (back != DialogResult.OK) return;
            //_names = frm.GetMemo();
            _qlr = frm.GetMemo2();
            _qlrbh = frm.GetMemo3();
            BuildMemo();
        }

        private void BuildMemo()
        {
            //StringBuilder builder=new StringBuilder();
            //builder.Append("经调查:");
            //if (_linkedObject is Zdjbxx)
            //{
            //    builder.Append("该宗地权利人");
            //}
            //builder.Append(_qlr);
            //builder.Append("使用人提供了");
            //builder.Append(_zjs);
            //builder.Append("。");
            //builder.Append(_gkj);

            //if (txtJS.SelectionLength > 0)
            //{
            //    //如果有选中的内容，则将光标移动到被选中内容之后
            //    txtJS.SelectionStart = txtJS.SelectionStart + txtJS.SelectionLength;
            //}
            //txtJS.SelectedText = builder.ToString();

            txtJS.Text = RemoveBehind(txtJS.Text, "经调查：");

            StringBuilder builder = new StringBuilder();
            builder.Append("经调查：");
            if (!string.IsNullOrEmpty(_qlr)) builder.Append(_qlr);
            if (!string.IsNullOrEmpty(_zjs)) builder.AppendFormat(",{0}", _zjs);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.YYZDMJ)) builder.AppendFormat(",{0}", _gkj.YYZDMJ);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.TDZH)) builder.AppendFormat(",{0}", _gkj.TDZH);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.PZWH)) builder.AppendFormat(",{0}", _gkj.PZWH);

            if (!string.IsNullOrEmpty(_qlrbh)) builder.AppendFormat(",{0}", _qlrbh);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.ZL)) builder.AppendFormat(",{0}", _gkj.ZL);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.JZ)) builder.AppendFormat(",{0}", _gkj.JZ);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.SZJZ)) builder.AppendFormat(",{0}", _gkj.SZJZ);

            if (_gkj != null && !string.IsNullOrEmpty(_gkj.XJFS)) builder.AppendFormat(",{0}", _gkj.XJFS);

            if (_gkj != null && !string.IsNullOrEmpty(_gkj.XZZDMJ)) builder.AppendFormat(",{0}", _gkj.XZZDMJ);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.LSYDMJ)) builder.AppendFormat(",{0}", _gkj.LSYDMJ);
            if (_gkj != null && !string.IsNullOrEmpty(_gkj.FCJZMJ)) builder.AppendFormat(",{0}", _gkj.FCJZMJ);
            builder.Append("。");
            txtJS.AppendText(builder.ToString());
        }

        private string RemoveBehind(string source, string match)
        {
            int idx = source.IndexOf(match, StringComparison.Ordinal);
            if (idx >= 0) return source.Remove(idx);
            return source;
        }

        private void btnZJ_Click(object sender, EventArgs e)
        {
            frmZJXZ frm = new frmZJXZ();
            if (frm.ShowDialog() == DialogResult.OK)
                _zjs = frm.GetMemo();
            BuildMemo();
        }

        private void btnGKJ_Click(object sender, EventArgs e)
        {
            frmGKJ frm = new frmGKJ();
            if (frm.ShowDialog() == DialogResult.OK)
                _gkj = frm.GetGkj();
            BuildMemo();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtJS.Text = RemoveBehind(txtJS.Text, "经调查：");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string GetMemo()
        {
            return txtJS.Text;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BuildMemo();
        }
    }
}
