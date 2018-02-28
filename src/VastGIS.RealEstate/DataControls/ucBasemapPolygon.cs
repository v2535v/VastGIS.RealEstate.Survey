﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using VastGIS.RealEstate.Api.Interface;
using VastGIS.RealEstate.Data.Entity;
using VastGIS.RealEstate.Data.Interface;

namespace VastGIS.Plugins.RealEstate.DataControls
{
    public partial class ucBasemapPolygon:UserControl,IEntityControl
    {	
        #region 变量
        private Dictionary<string,string> _dictionaryNames;
        private IBasemapPolygon _dxtdldwm;
        private IREDatabase _database;
        private bool _hasChanged = false;
        #endregion
        
        public ucBasemapPolygon()
        {
            InitializeComponent();
            _dictionaryNames = new Dictionary<string, string>();
             intID.Enabled = false;
            _hasChanged=false;
        }
        
        private void InitDictionaries()
        {
            foreach (var onepair in _dictionaryNames)
            {
                string dName = onepair.Key;
                string dValue = onepair.Value;
                List<VgDictionary> _dicts = _database.DomainService.GetDictionaryByName(dValue);
                ComboBoxAdv combo = FindControl(this,"cmb" + onepair.Key) as ComboBoxAdv;
                combo.DataSource = _dicts;
                combo.DisplayMember ="Zdsm";
                combo.ValueMember ="Zdz";
            }
        }
        
        private Control FindControl(Control control, string controlName)
        {
            Control c1;
            foreach (Control c in control.Controls)
            {
                if (c.Name == controlName)
                {
                    return c;
                }
                else if (c.Controls.Count > 0)
                {
                    c1 = FindControl(c, controlName);
                    if (c1 != null)
                    {
                        return c1;
                    }
                }
            }
            return null;
        }
        
        public void LinkObject(IREDatabase database,IEntity entity)
        {
            _database = database; 
            if(_dictionaryNames != null && _dictionaryNames.Count > 0)
            {
                InitDictionaries();
            }
            _dxtdldwm=entity as IBasemapPolygon;
            intID.DataBindings.Clear();
            intID.DataBindings.Add("IntegerValue",_dxtdldwm,"ID");
            txtTc.DataBindings.Clear();
            txtTc.DataBindings.Add("Text",_dxtdldwm,"Tc");
            txtCassdm.DataBindings.Clear();
            txtCassdm.DataBindings.Add("Text",_dxtdldwm,"Cassdm");
            txtFsxx1.DataBindings.Clear();
            txtFsxx1.DataBindings.Add("Text",_dxtdldwm,"Fsxx1");
            txtFsxx2.DataBindings.Clear();
            txtFsxx2.DataBindings.Add("Text",_dxtdldwm,"Fsxx2");
            txtYsdm.DataBindings.Clear();
            txtYsdm.DataBindings.Add("Text",_dxtdldwm,"Ysdm");
            
            ((INotifyPropertyChanged)_dxtdldwm).PropertyChanged += Entity_PropertyChanged;
            _hasChanged=false;
        }

        private void Entity_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            _hasChanged=true;
        }
        
        #region IEntityControl接口
        public bool HasChanged{get{return _hasChanged;}}
        public bool Save()
        {
            return _database.SystemService.Save((IEntity)_dxtdldwm);
        }
        public void Delete()
        {
            _database.SystemService.Delete((IEntity)_dxtdldwm);
        }        
        #endregion
        
        
    }
}