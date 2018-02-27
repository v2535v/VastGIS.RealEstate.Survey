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
using VastGIS.Plugins.RealEstate.Events;
using VastGIS.Plugins.RealEstate.Forms;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.Shared;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucSelectLayer : UserControl
    {
        private List<VgObjectclass> _sourceClasses;
        private GeometryType _geometryType;
        private VgObjectclass _selectedClass;
        private List<VgObjectclass> _selectedClasses;
        private bool _isSingle;
        private GeometryType _limitedGeometryType;

        public delegate void SelectedClassChanged(object sender, ObjectClassEventArgs e);

        public event SelectedClassChanged ucSelectedClassChanged;


        public ucSelectLayer()
        {
            InitializeComponent();
            _selectedClass = null;
            _limitedGeometryType=GeometryType.None;
        }

        public void SetClasses(List<VgObjectclass> sourceClasses)
        {
            _sourceClasses = sourceClasses;
            _selectedClasses=new List<VgObjectclass>();
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
            get
            {
                return _geometryType;
            }
            set
            {
                _geometryType = value;
               
            }
        }

        public GeometryType LimitedGeometryType
        {
            get { return _limitedGeometryType; }
            set { _limitedGeometryType = value; CheckValues(); }
        }

        private void CheckValues()
        {
            if (_limitedGeometryType != GeometryType.None)
            {
                if (_selectedClass != null)
                {
                    if (_selectedClass.Txlx != (int)_limitedGeometryType) _selectedClass = null;
                }
                if (_selectedClasses != null)
                {
                    List<VgObjectclass> classes = _selectedClasses.Where(c => c.Txlx == (int)_limitedGeometryType).ToList();
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
            frmSelectLayer frmSelected=new frmSelectLayer(_sourceClasses, _limitedGeometryType);
            if (_isSingle) frmSelected.SelectionMode = SelectionMode.One;
            else frmSelected.SelectionMode = SelectionMode.MultiExtended;


            if (frmSelected.ShowDialog() != DialogResult.OK) return;
            if (_isSingle)
            {
                _selectedClass = frmSelected.SelectedObjectClasses.Count > 0
                                     ? frmSelected.SelectedObjectClasses[0]
                                     : null;
                _geometryType = (GeometryType)_selectedClass.Txlx;
            }
            else _selectedClasses = frmSelected.SelectedObjectClasses;
            LoadText();
            if (ucSelectedClassChanged != null)
            {
                ucSelectedClassChanged(sender,new ObjectClassEventArgs(_isSingle, _selectedClasses));
            }

        }

        public VgObjectclass SelectedClass
        {
            get { return _selectedClass; }
            set
            {
                _selectedClass = value;
                LoadText();
            }
        }

        public List<VgObjectclass> SelectedClasses
        {
            get
            {
                if (!_isSingle) return _selectedClasses;
                else
                {
                    if (_selectedClass == null) return null;
                    List<VgObjectclass> tmpClasses = new List<VgObjectclass>();
                    tmpClasses.Add(_selectedClass);
                    return tmpClasses;
                }
            }
            set
            {
                _selectedClasses = value;
                LoadText();
            }
        }

        public void SetCurrentClass(VgObjectclass configEditingClass)
        {
            if (configEditingClass == null)
            {
                _selectedClass = null;
                LoadText();
                return;
            }

            VgObjectclass findClass = _sourceClasses.FirstOrDefault(c => c.Mc == configEditingClass.Mc);
            if (findClass != null)
            {
                _selectedClass = configEditingClass;
                _geometryType =(GeometryType) _selectedClass.Txlx;
                LoadText();
                return;
            }
        }

        public void SetCurrentClass(List<VgObjectclass> configEditingClasses)
        {
                _selectedClasses = configEditingClasses;
                LoadText();
                return;
           
        }
    }
}
