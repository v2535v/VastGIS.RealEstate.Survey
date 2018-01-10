using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VastGIS.Api.Enums;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Shared;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSelectLayer : UserControl
    {
        private List<VgObjectclasses> _sourceClasses;
        private GeometryType _geometryType;
        private VgObjectclasses _selectedClass;
        private List<VgObjectclasses> _selectedClasses;
        private bool _isSingle;
        
        public ucSelectLayer()
        {
            InitializeComponent();
            _selectedClass = null;
        }

        public void SetClasses(List<VgObjectclasses> sourceClasses)
        {
            _sourceClasses = sourceClasses;
            _selectedClasses=new List<VgObjectclasses>();
            _selectedClass = null;
            _isSingle = true;
        }

        public string Label
        {
            get { return btnTargetLayer.Text; }
            set { btnTargetLayer.Text = value; }
        }

        public bool SingleSelect
        {
            get { return _isSingle; }
            set { _isSingle = value;
                CheckValues();
            }
        }

        public GeometryType GeometryType
        {
            get { return _geometryType; }
            set
            {
                _geometryType = value;
                CheckValues();
            }
        }

        private void CheckValues()
        {
            if (_geometryType != GeometryType.None)
            {
                if (_selectedClass != null)
                {
                    if (_selectedClass.Txlx != (int)_geometryType) _selectedClass = null;
                }
                if (_selectedClasses != null)
                {
                    List<VgObjectclasses> classes = _selectedClasses.Where(c => c.Txlx == (int)_geometryType).ToList();
                    _selectedClasses = classes;
                }

                LoadText();
            }
        }

        private void LoadText()
        {
            if (_isSingle)
            {
                txtTarget.Text = _selectedClass != null ? _selectedClass.Zwmc : "";
            }
            else
            {
                string[] names=null;
                if (_selectedClasses != null)
                {
                     names = _selectedClasses.Select(c => c.Zwmc).ToArray();
                }
                txtTarget.Text = names == null || names.Length == 0 ? "" : StringHelper.Join(names, ",");
            }
        }

        private void btnTargetLayer_Click(object sender, EventArgs e)
        {
            frmSelectLayer frmSelected=new frmSelectLayer(_sourceClasses,_geometryType);
            if (_isSingle) frmSelected.SelectionMode = SelectionMode.One;
            else frmSelected.SelectionMode = SelectionMode.MultiExtended;


            if (frmSelected.ShowDialog() != DialogResult.OK) return;
            if (_isSingle)
                _selectedClass = frmSelected.SelectedObjectClasses.Count > 0
                                     ? frmSelected.SelectedObjectClasses[0]
                                     : null;
            else _selectedClasses = frmSelected.SelectedObjectClasses;
            LoadText();

        }

        public VgObjectclasses SelectedClass
        {
            get { return _selectedClass; }
            set { _selectedClass = value;}
        }

        public List<VgObjectclasses> SelectedClasses
        {
            get { return _selectedClasses; }
            set { _selectedClasses = value; }
        }
    }
}
